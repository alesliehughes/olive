
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public class BooleanKeyFrameCollection : Freezable, IList, ICollection, IEnumerable
{
	public BooleanKeyFrameCollection ()
	{
	}

	public int Count {
		get { throw new NotImplementedException (); }
	}

	public static BooleanKeyFrameCollection Empty {
		get { throw new NotImplementedException (); }
	}

	public bool IsFixedSize {
		get { throw new NotImplementedException (); }
	}

	public bool IsReadOnly {
		get { throw new NotImplementedException (); }
	}

	public bool IsSynchronized {
		get { throw new NotImplementedException (); }
	}

	public object SyncRoot {
		get { throw new NotImplementedException (); }
	}

	public BooleanKeyFrame this[int index] {
		get { throw new NotImplementedException (); }
		set { throw new NotImplementedException (); }
	}

	object IList.this[int index] {
		get { return this[index]; }
		set { this[index] = (BooleanKeyFrame)value; }
	}

	public int Add (BooleanKeyFrame keyFrame)
	{
		throw new NotImplementedException ();
	}

	int IList.Add (object value)
	{
		return Add ((BooleanKeyFrame) value);
	}

	public void Clear ()
	{
		throw new NotImplementedException ();
	}

	public new BooleanKeyFrameCollection Clone ()
	{
		throw new NotImplementedException ();
	}

	protected override void CloneCore (Freezable sourceFreezable)
	{
		throw new NotImplementedException ();
	}

	protected override void CloneCurrentValueCore (Freezable sourceFreezable)
	{
		throw new NotImplementedException ();
	}

	public bool Contains (BooleanKeyFrame keyFrame)
	{
		throw new NotImplementedException ();
	}

	bool IList.Contains (object value)
	{
		return Contains ((BooleanKeyFrame)value);
	}

	public void CopyTo (BooleanKeyFrame[] array, int index)
	{
		throw new NotImplementedException ();
	}

	void ICollection.CopyTo (Array array, int index)
	{
		CopyTo ((BooleanKeyFrame[])array, index);
	}

	protected override Freezable CreateInstanceCore ()
	{
		throw new NotImplementedException ();
	}

	protected override bool FreezeCore (bool isChecking)
	{
		throw new NotImplementedException ();
	}

	protected override void GetAsFrozenCore (Freezable sourceFreezable)
	{
		throw new NotImplementedException ();
	}

	protected override void GetCurrentValueAsFrozenCore (Freezable sourceFreezable)
	{
		throw new NotImplementedException ();
	}

	public IEnumerator GetEnumerator()
	{
		throw new NotImplementedException ();
	}

	public int IndexOf (BooleanKeyFrame keyFrame)
	{
		throw new NotImplementedException ();
	}

	int IList.IndexOf (object value)
	{
		return IndexOf ((BooleanKeyFrame) value);
	}

	public void Insert (int index, BooleanKeyFrame keyFrame)
	{
		throw new NotImplementedException ();
	}

	void IList.Insert (int index, object value)
	{
		Insert (index, (BooleanKeyFrame)value);
	}

	public void Remove (BooleanKeyFrame keyFrame)
	{
		throw new NotImplementedException ();
	}

	void IList.Remove (object value)
	{
		Remove ((BooleanKeyFrame) value);
	}

	public void RemoveAt (int index)
	{
		throw new NotImplementedException ();
	}
}


}
