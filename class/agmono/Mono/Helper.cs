//
// Helper.cs
//
// Authors:
//   Miguel de Icaza (miguel@novell.com)
//   Chris Toshok (toshok@novell.com)
//
// Copyright 2007 Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Reflection;
using System.ComponentModel;

namespace Mono {

	public class Helper {

		private static TypeConverter GetConverterFor (PropertyInfo info)
		{
			Attribute[] attrs = (Attribute[])info.GetCustomAttributes (true);
			TypeConverterAttribute at = null;
			TypeConverter converter = null;

			foreach (Attribute attr in attrs) {
				if (attr is TypeConverterAttribute) {
					at = (TypeConverterAttribute)attr;
					break;
				}
			}

			if (at == null || at == TypeConverterAttribute.Default)
				converter = TypeDescriptor.GetConverter (info.PropertyType);
			else {
				Type t = Type.GetType (at.ConverterTypeName);
				if (t == null) {
					converter = TypeDescriptor.GetConverter (info.PropertyType);
				}
				else {
					ConstructorInfo ci = t.GetConstructor (new Type[] { typeof(Type) });
					if (ci != null)
						converter = (TypeConverter) ci.Invoke (new object[] { info.PropertyType });
					else
						converter = (TypeConverter) Activator.CreateInstance (t);
				}
			}
			return converter;
		}
		
		public static void SetPropertyFromString (object target, string name, string value, out string error)
		{
			PropertyInfo pi = target.GetType ().GetProperty (name);
			if (pi == null){
				error = "no property descriptor found";
				return;
			}

			TypeConverter converter = GetConverterFor (pi);
			if (!converter.CanConvertFrom (typeof (string))){
				//
				// MS does not seem to handle this yet either, but I think a logical improvement
				// here is to call back into unmanaged code something like xaml_create_object_from_str
				// with the attribute string, and see if the managed code can parse it, this would
				// allow you to stick things like Colors and KeySplines on your object and still have
				// custom setters
				//

				error = "unable to convert to this type from a string";
				return;
			}

			error = null;
			try {
				pi.SetValue (target, converter.ConvertFrom (value), null);
			} catch (Exception e) {
				error = e.ToString ();
			}
		}
	}
}