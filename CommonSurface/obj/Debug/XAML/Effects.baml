   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   showAnimSec  �� 
TargetName �� TargetProperty<   6System.Windows.Media.Animation.EasingThicknessKeyFrame p� KeyTime p� Value    EasingFunction-  'System.Windows.Media.Animation.BackEase7  1System.Windows.Media.Animation.EasingFunctionBase   
EasingMode8  2System.Windows.Media.Animation.EasingPointKeyFrame $� KeyTime $� Value9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime	 O� Value
   EasingFunction  hideAnimSec  animHelp4  .System.Windows.Media.Animation.ExponentialEase   Exponent  fadeAnim  
defadeAnim  animFromLeft g� FillBehavior0  *System.Windows.Media.Animation.QuarticEase  animFromRight0  *System.Windows.Media.Animation.QuinticEase  animFromLeft2  	animFloat/  )System.Windows.Media.Animation.CircleEase 	 animDefloat 
 	animHover  	animClick  animClickLeft�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      6W   %G  &	       &	 %   &	 �    &	 %    &	 �    &	 #    &	 p    &	 �    &	     &		 �    &	
    &	 �   &	 �   �� 5      $  canvas��5      .��5      r� $ (FrameworkElement.Margin)�6%   .	�5	         $ 0:0:1��6   $ 0,0,0,0q�6-    5
        5      $ EaseOut=�6   5      5      *� 5      $  canvas��6!   $' !(UIElement.RenderTransformOrigin)�6@   .'�5        $ 0��6   $ 0.5,0.5&�6%     5      $ 0:0:1��6   $ 0.5,0.5&�6)   5      U� 5      $  canvas��6"   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6A   .\�5        $ 0��6   $	 0Q�6&   
 5        5      $ EaseOut=�6   5        5      $ 0:0:1��6   $	 1Q�6*   
 5        5      $ EaseOut=�6   5      5      U� 5      $  canvas��6"   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6A   .\�5         $ 0��6   $	 0Q�6&   
 5!        5"      $ EaseOut=�6   5$        5%      $ 0:0:1��6   $	 1Q�6*   
 5&        5'      $ EaseOut=�6   5)      5*      5+      �� 5-      .��5.      r� $ (FrameworkElement.Margin)�6%   .	�5/         $ 0:0:1��6   $ 
2850,0,0,0q�6-    50        51      $ 	EaseInOut=�6   53      54      55      �� 56      .��57      U� $  puzHelp��6"   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleX)�6B   .\�58        $ 0��6   $	 0Q�6&   
 59        5:      $ 	EaseInOut=�6   $ 13Q�6.   5<        5=      $ 	0:0:1.684��6   $	 1Q�6.   
 5>        5?      $ 	EaseInOut=�6   $ 13Q�6.   5A        5B      $ 0:0:8��6   $	 0Q�6*   
 5C        5D      $ 	EaseInOut=�6   $ 13Q�6.   5F      5G      U� 5H      $  puzHelp��6"   $V P(UIElement.RenderTransform).(TransformGroup.Children)[0].(ScaleTransform.ScaleY)�6B   .\�5I        $ 0��6   $	 0Q�6&   
 5J        5K      $ 	EaseInOut=�6   $ 13Q�6.   5M        5N      $ 	0:0:1.684��6   $	 1Q�6.   
 5O        5P      $ 	EaseInOut=�6   $ 13Q�6.   5R        5S      $ 0:0:8��6   $	 0Q�6*   
 5T        5U      $ 	EaseInOut=�6   $ 13Q�6.   5W      5X      U� 5Y      $  puzHelp��6"   $V P(UIElement.RenderTransform).(TransformGroup.Children)[2].(RotateTransform.Angle)�6B   .\�5Z        $ 0:0:0.4��6   $	 0Q�6,     5[      $ 0:0:1.06��6   $	 22Q�6-     5\      $ 0:0:3.7��6   $	 0Q�6,   5]      U� 5^      $  canvas1��6"   $ (UIElement.Opacity)�6B   .\�5_        $ 0��6   $
	 0.05Q�6&     5`      $ 0:0:3��6   $	 1Q�6*   5a      U� 5b      $  canvas2��6"   $ (UIElement.Opacity)�6B   .\�5c        $ 0��6   $
	 0.05Q�6&     5d      $ 0:0:3��6   $	 1Q�6*   5e      5f      �� 5h      .��5i      U� $ (UIElement.Opacity)�6"   .\�5j        $ 0:0:1��6   $	 0Q�6*   5k      5l      �� 5n      .��5o      U� $ (UIElement.Opacity)�6"   .\�5p        $ 0:0:2��6   $	 1Q�6*   5q      5r      �� 5s      $
 Stop=�6#   .��5t      U� $  imageJardin��6"   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6F   .\�5u        $ 0:0:1��6   $		 640Q�6*   
 5v        5w      $ 	EaseInOut=�6   5y        5z      $ 0:0:14��6   $
	 1004Q�6+   5{      5|      �� 5}      $
 Stop=�6$   .��5~      U� $  imagePremier��6"   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6G   .\�5�        $ 0:0:1��6   $
	 -644Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�        5�      $ 0:0:10.4��6   $	 -1004Q�6-   5�      5�      �� 5�      $
 Stop=�6$   .��5�      U� $  imageDeuxieme��6"   $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6H   .\�5�        $ 0:0:1��6   $		 644Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�        5�      $ 0:0:11��6   $
	 1004Q�6+   5�      5�      �� 5�      .��5�      U� $3 -(UIElement.Effect).(DropShadowEffect.Opacity)�6"   .\�5�        $ 0��6   $	 0Q�6&   
 5�        5�      $ 	EaseInOut=�6   5�        5�      $ 0:0:1��6   $	 1Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�      5�      U� 5�      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6"   .\�5�        $ 0��6   $	 0Q�6&   
 5�        5�      $ 	EaseInOut=�6   5�        5�      $ 0:0:1��6   $
	 -2.5Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�      5�      5�      �� 5�      .��5�      U� $3 -(UIElement.Effect).(DropShadowEffect.Opacity)�6"   .\�5�      �� $ 0��6   $	 1Q�6&   �� 5�      $ 0:0:1��6   $	 0Q�6*   5�      U� 5�      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6"   .\�5�      �� $ 0��6   $
	 -2.5Q�6&   �� 5�      $ 0:0:30��6   $	 0Q�6+   5�      5�      �� 5�      .��5�      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6"   .\�5�        $ 0:0:2��6   $	 60Q�6*   
 5�        5�      $ EaseOut=�6   5�      5�      U� 5�      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6"   .\�5�        $ 0:0:2��6   $	 0Q�6*   
 5�        5�      $ EaseOut=�6   5�      5�      5�      �� 5�      .��5�      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6"   .\�5�        $ 0:0:1��6   $		 200Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�      5�      5�      �� 5�      .��5�      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6"   .\�5�        $ 0:0:1��6   $	 0Q�6*   
 5�        5�      $ 	EaseInOut=�6   5�      5�      5�      5�      