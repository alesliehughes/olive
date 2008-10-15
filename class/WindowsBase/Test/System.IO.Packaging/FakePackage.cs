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
// Copyright (c) 2008 Novell, Inc. (http://www.novell.com)
//
// Authors:
//	Alan McGovern (amcgovern@novell.com)
//


using System;
using System.Collections.Generic;

namespace System.IO.Packaging.Tests {
	
    public class FakePackage : Package {
        public FakePackage (FileAccess access, bool streaming)
            : base (FileAccess.Read, streaming)
        {

        }

        protected override PackagePart CreatePartCore (Uri partUri, string contentType, CompressionOption compressionOption)
        {
            throw new NotImplementedException ();
        }

        protected override void DeletePartCore (Uri partUri)
        {
            throw new NotImplementedException ();
        }

        protected override void FlushCore ()
        {
            throw new NotImplementedException ();
        }

        protected override PackagePart GetPartCore (Uri partUri)
        {
            throw new NotImplementedException ();
        }

        protected override PackagePart [] GetPartsCore ()
        {
            throw new NotImplementedException ();
        }
    }
}