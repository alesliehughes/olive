
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public abstract class PointAnimationBase : AnimationTimeline
{
	protected PointAnimationBase () { }

	public override sealed Type TargetPropertyType { get { return typeof (Point); } }

	public new PointAnimationBase Clone ()
	{
		throw new NotImplementedException ();
	} 

	public override sealed object GetCurrentValue (object defaultOriginValue, object defaultDestinationValue, AnimationClock animationClock)
	{
		return GetCurrentValue ((Point)defaultOriginValue, (Point) defaultDestinationValue, animationClock);
	}

	protected abstract Point GetCurrentValueCore (Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock);


	public Point GetCurrentValue (Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock)
	{
		throw new NotImplementedException ();
	}


}


}
