
/* this file is generated by gen-animation-types.cs.  do not modify */

using System;
using System.Collections;
using System.ComponentModel;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Markup;

namespace System.Windows.Media.Animation {


public class PointAnimation : PointAnimationBase
{
	public static readonly DependencyProperty ByProperty
				= DependencyProperty.Register ("By", typeof (Point?), typeof (PointAnimation));
	public static readonly DependencyProperty FromProperty
				= DependencyProperty.Register ("From", typeof (Point?), typeof (PointAnimation));
	public static readonly DependencyProperty ToProperty
				= DependencyProperty.Register ("To", typeof (Point?), typeof (PointAnimation));

	public PointAnimation ()
	{
	}

	public PointAnimation (Point toValue, Duration duration)
	{
	}

	public PointAnimation (Point toValue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public PointAnimation (Point fromValue, Point toValue, Duration duration)
	{
	}

	public PointAnimation (Point fromValue, Point tovalue, Duration duration, FillBehavior fillBehavior)
	{
	}

	public Point? By {
		get { return (Point?) GetValue (ByProperty); }
		set { SetValue (ByProperty, value); }
	}

	public Point? From {
		get { return (Point?) GetValue (FromProperty); }
		set { SetValue (FromProperty, value); }
	}

	public Point? To {
		get { return (Point?) GetValue (ToProperty); }
		set { SetValue (ToProperty, value); }
	}

	public bool IsAdditive {
		get { return (bool) GetValue (AnimationTimeline.IsAdditiveProperty); }
		set { SetValue (AnimationTimeline.IsAdditiveProperty, value); }
	}

	public bool IsCumulative {
		get { return (bool) GetValue (AnimationTimeline.IsCumulativeProperty); }
		set { SetValue (AnimationTimeline.IsCumulativeProperty, value); }
	}

	public new PointAnimation Clone ()
	{
		throw new NotImplementedException ();
	}

	protected override Freezable CreateInstanceCore ()
	{
		throw new NotImplementedException ();
	}

	protected override Point GetCurrentValueCore (Point defaultOriginValue, Point defaultDestinationValue, AnimationClock animationClock)
	{
		throw new NotImplementedException ();
	}
}


}
