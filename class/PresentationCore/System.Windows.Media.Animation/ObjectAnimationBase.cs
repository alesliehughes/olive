
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public abstract class ObjectAnimationBase : AnimationTimeline
{
	protected ObjectAnimationBase () { }

	public override sealed Type TargetPropertyType { get { return typeof (object); } }

	public new ObjectAnimationBase Clone ()
	{
		throw new NotImplementedException ();
	} 

	public override sealed object GetCurrentValue (object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
	{
		return GetCurrentValue ((object)defaultOriginValue, (object) defaultDestinationValue, animationClock);
	}

	protected abstract object GetCurrentValueCore (object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock);


}


}
