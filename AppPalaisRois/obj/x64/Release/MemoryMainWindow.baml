   M S B A M L   `   `   `  ����   AppPalaisRois$    AppPalaisRois.MemoryMainWindow   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     e aMicrosoft.Surface.Presentation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e351s)http://schemas.microsoft.com/surface/2008    � Title$  	AppMemory��$
��1920��$
��1080�� � WindowState$ 	Maximized=� � WindowStyle$
 None=�.��� -    �Name$ MemoryPanel��
���   �.+��� -    ��Name$ imageBackground���� -    ��Name$ canvas��$
��1920��$
��1080��.+�� -    �Name$ ChoixMemory�� �� Left$	 510��
 �� Top$	 390��$	��300��$��Center=�$��Center=�y��� *ChoiceVisibility+� -   $ 
MemoryGrid��$	 660��$��0,0,8,0q�$��Center=�$��Center=�.+��� $��0q�$��Center=�$��Center=�	 K� ZIndex$	 1��{��� *
NotGameEnd+���� *Cards+
 �� Mode$
 TwoWay=�y��� *ItemsControlVisibility+���� .R�� $ wp��$��Center=�$��Center=�
������ ���� *
GameSize+$
 TwoWay=����� .R�� $��mygrid��.+���  ��Name$
 mask��
������� �� CornerRadius �� *
MyRadius+$
 TwoWay=���  ��Name$ stack��$	��120��$	��120�� J� OpacityMask !�  !� Visual ��  �� ElementName$
 mask��.+��� $	 ima��-   $	��170��$	��100��$��10q�$��Center=�$��Center=�$��Uniform=� J� Opacity �� *Fading+���� *	BmpSource+ �� Triggers ��  �� Value$
 True�� �� Binding �� *Solved+ N� EnterActions �� .���� .��t�  �� 
TargetName$	 ima�� �� TargetProperty$ Margin�	 t� To$ 0,10,0,0X� g� Duration$ 0:0:0D��� $
 True�� �� *Front+ �� .���� .��W�  g� AutoReverse . $	 ima��$ Width� W� From$	 100X�	 W� To$	 100X�$ 0:0:0.15D�W�  . $	 ima��$ Height�$	 100X�$ 80X�$ 0:0:0.15D� N� ExitActions �� .���� .��W�  . $	 ima��$ Width�$	 100X�$ 80X�$ 0:0:0.15D�W�  . $	 ima��$ Height�$	 100X�$ 80X�$ 0:0:0.15D��� $
 True�� �� *Fade+ �� .���� .��W� $	 ima��$ Opacity�$	 1.0X�$	 0.3X�$ 0:0:1D� �� .���� .��W� $	 ima��$ Opacity�$	 0.3X�$	 1.0X�$ 0:0:1D��� $
 True�� �� *	GameEnd+ �� .���� .��t� $	 ima��$ Margin�$ 0,0,0,0X�$ 0:0:1D�W� $	 ima��$ Width�$	 100X�$	 120X�$ 0:0:1D�W� $	 ima��$ Height�$	 100X�$	 120X�$ 0:0:1D�r� -    r�Name$ 	VideoTuto��$
��1064��$��0q�$��Center=�$��Center=�$		 999�� r� Stretch$
 Fill=�  r� Volume$  0Q�! r� Source! �� *Tuto.Chemin+y��� *VisibilityAide+� $	��120��$	��120��$��760,50,0,902q�$��Center=�$��Center=�y��� *ItemsControlVisibility+.+��� -   $ sablier��$	��100��$	��100��$��Center=�" J� RenderTransformOrigin$" 0.5,0.5&�# � Triggers# :� $ :� RoutedEvent$$ FrameworkElement.Loaded��.[��� .���� .��W�  . % g� RepeatBehavior$% Forever��$ sablier��$ Opacity�$	 1.0X�$	 0.3X�$ 0:0:5D�� $��885,80,847,902q�y��� *ItemsControlVisibility+.+��� $	��155��$��Center=�   Luciole-Regular#��[  $��45(�
�������$��WrapWithOverflow=����� *	TimerGame+� $��1040,50,0,942q�$��Center=�$��Center=�y��� *ItemsControlVisibility+.+��� -	   $ etoile1��$��80��$��80��$��Center=����� *Star1Control+�� -
   $ etoile2��$��80��$��80��$��Center=����� *Star2Control+�� -   $ etoile3��$��80��$��80��$��Center=����� *Star3Control+�� -   & ��Name$& Quit_button��$��90��$��90��$��
75,960,0,0q�$��Center=�$	��Top=�
������ 
������ .���� $��80��$��80��.+��� -   $ returnMemory��$��Uniform=��� -   ' ��Name$' 	labelEasy��$��90��$��605,609,1217,412q�$��Center=�$	 3�����	#00000000#��[  $��28(�
��������� -   $' labelMedium��$	��110��$��913,609,889,412q�$��Center=�$	 3�����	#00000000#��[  $��28(�
��������� -   $' 	labelHard��$	��115��$��1214,609,583,412q�$��Center=�$	 3�����	#00000000#��[  $��28(�
�������