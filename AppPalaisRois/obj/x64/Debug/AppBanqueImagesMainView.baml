   M S B A M L   `   `   `  ����C  ?FluidKit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG1clr-namespace:FluidKit.Controls;assembly=FluidKitFluidKit.Controls  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5       AppPalaisRois+   %AppPalaisRois.AppBanqueImagesMainView   5      ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Ffluidkit1clr-namespace:FluidKit.Controls;assembly=FluidKit     5      e aMicrosoft.Surface.Presentation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e351s)http://schemas.microsoft.com/surface/2008  5      0sys&clr-namespace:System;assembly=mscorlib  5      -   5          �Name$  BanqueImages��5       � Title$ BanqueImages��5	      $
��1920��5
      $
��1080��5      $��0q�5      $��0q�5       � WindowState$ 	Maximized=�5       � WindowStyle$
 None=�5       � 	Resources 5         ListTemplate �� Path  
Background ��Name �� Padding  NoNothingButton �� 
TargetType	 �� Property
 �� Value3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction   Opacity �� 
TargetType  PlaceHoldersList ��Name J� Opacity��%�  &	        &	 �     &	 m    &	      7  �� 5   
   .R�5      � $	��120��6   $	��120��6   .+�5      �� $
��Fill=�5      ��5      �� $ 	Thumbnail�5      5      5      �� 5      .R�5      �� $ ElementVisual��5      $��0��5      $ 0q�5      
������ 
������ $��0q�5"      ._�5#      �� $��Uniform=�6   ��6   �� 6   5$      5%      �� 5'      " ��6"   .�5(      �� 	 �@�OverridesDefaultStyle
 . 6-   �� 5)      	 �@�Cursor$	
 Pen��6   �� 5*      	 � ��$
 Center=�6)   �� 5+      	 � ��$
 Center=�6+   �� 5,      	 � ��
 �	#010000006"   �� 5-      	 � z�
 5.      V� 5/      .~�50      �� �� 51      �� 52      T� 53      54      56      �� 57      	 �@J�Effect
 58        59      $ 36Q�5:      $	 275Q�5;      $ 0Q�5<      5>      �� 5@      	 � ��
 5A      �� 5B      " ��6   .R�5C      �� $ border��6   #��z��6   ._�5D   	   �� $��Center=�6   $��Center=�67   5E   	   5F      5H      5I      �� 5L      " ��6#   .�5N      �� 	 � ��
 5O      �� 5P      .R�5Q      �� $ canvas��6!   5R      5T      �� 5V      	 � ��
 5W      �� 5X      .R�5Y      �� -   5        8��  $ 1Q�5Y   J   .��5Z   	   �� $
��None=�6+   ��6   �� *
IconPath+6+   5[   	   5\      5^      5_      5`      .��5c      � -   5         �Name$ BanqueImagesPanel��5d      $
��1920��5e      $
��1080��5f      
������ .+�5i      �� -   5         ��Name$ 	imageFond��5j      ��5k      �� $ ActualWidth� �� ElementName$ BanqueImagesPanel����5l      �� $ ActualHeight�$ BanqueImagesPanel��� 5n       � ColumnDefinitions 5o      �� 5p      $��* �6   �� 5q      $
��1490 �6   �� 5r      $��* �6    � RowDefinitions 5t      �� 5u      $��* �6   �� 5v      $	��780 �6   �� 5w      $��3* �6   .+�5{      #   FluidKit.Controls.ElementFlow  -   5          Name$ 	flowCarte��5|      $��1��5}      $��1��5~         ElementHeight$	 780Q�5         ElementWidth$
 1490Q�5�      #���  5�         Layout 5�      !   FluidKit.Controls.CoverFlow  5�         Camera 5�      =� 5�      -   5        
camera�� =� FieldOfView$
 1500Q�5�       � LookDirection$ 0,0,-65�5�       � Position$ 0,0,2.651�5�      5�      �� 5�      $��1��5�      $��1��5�      $��0q�5�       J� RenderTransformOrigin$	 0,0&�5�      #��[ 5�      ��5�      �� *Selected.PlaceHolders+��5�      �� 5�      .�5�      �� 	 �@��Top
 6%   �� $ Y��� 5�      	 �@��Left
 6&   �� $ X�5�      5�      �� 5�      -   5         ��Name$ Quit_button��5�      $��2��5�      $��0��5�      $	��120��5�      $	��120��5�      $��Center=�5�      $��Center=�5�      ��5�      Z� ��5�      Z� .��5�      �� .+�5�      �� -   5        $ returnBanqueImages��5�      $	��100��5�      $	��100��5�      $	 1.0Q�5�      5�      5�      �� 5�      $��2��5�      $��1��5�      $
��0,20q�5�      $��Center=�5�        �� Orientation$  
Horizontal=�5�      .+�5�      �� -	   5        ! ��Name$! listboxMaps��5�      $
��1490��5�      $��Center=�5�      $��Center=�5�      
������ $��0q�5�      #��[  5�      $��Hidden=�5�      " �� SelectionMode$" Single=�5�      ��5�      �� *Maps+��5�      �� 5�      .R�5�   	   � # K� IsItemsHost# . 6   5�   	   5�      5�      9  3Microsoft.Surface.Presentation.Controls.ScatterView  5�      -
   5        $  Name$$ ScatterView��5�      $��1��5�      $��1��5�      $��0q�5�      $��0q�5�      $
��Left=�5�      $	��Top=�5�      % J� IsHitTestVisible% . & J� IsManipulationEnabled& . y�5�      �� *ScatterViewVisibility+.@�5�      =  7Microsoft.Surface.Presentation.Controls.ScatterViewItem  $��0q�5�      $��1q�5�      G  AMicrosoft.Surface.Presentation.Controls.ScatterContentControlBase'   CanMove' . (   	CanRotate( . )   CanScale) . *   Center$* 745,390&�5�      & .  +   IsTopmostOnActivation+ . ,   Orientation$, 0Q�5�      -   ZIndex$- 1��5�      ��5�      �� $ ActualWidth�$ ScatterView����5�      �� $ ActualHeight�$ ScatterView����5�      Z� 5�      5�      5�      5�      5�      