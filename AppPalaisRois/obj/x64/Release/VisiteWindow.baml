   M S B A M L   `   `   `  ����   AppPalaisRois     AppPalaisRois.VisiteWindow   ^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     e aMicrosoft.Surface.Presentation, Version=2.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e351s)http://schemas.microsoft.com/surface/2008    � Title$  VisiteModel��$
��1920��$
��1080�� � WindowState$ 	Maximized=� � WindowStyle$
 None=� � 	Resources    sbShowRightMenu g� AccelerationRatio �� TargetProperty t� From	 t� To g� Duration  sbHideRightMenu  sbReduceWebBrowser	 W� From	
 W� To  sbExpandWebBrowser  VisiteTemplate �� 
TargetType �� Property �� Value �� 
TargetType �� Orientation r� Stretch r� UnloadedBehavior r� Volume r� Source �� Path��%$  &	        &	 O     &	 �     &	 �     &	 (    �� .��t� $	 0.5Q�$ Margin�$ 
0,0,-500,0X�$ 0,0,0,0X�$ 0:0:0D��� .��t� $	 0.5Q�$ Margin�$ 0,0,0,0X�$ 
0,0,-500,0X�$ 0:0:0D��� .��W� $	 0.5Q�$ Width�$
	 1900X�$

 1400X�$ 0:0:0D��� .��W� $	 0.5Q�$ Width�$
	 1400X�$

 1900X�$ 0:0:0D��� " ��.���  � �� �� " ��.R��� $
��10,0q�
������ $ 
Horizontal=�.+�r� -   $	��130��$	��130��$��0q�$��Stretch=�$ Uniform=�$ Manual=�$ 0Q� �� $ 	Thumbnail�.��� -    �Name$ 	appVisite��
���   � � RowDefinitions �� $��* ��� $
��1080 ��� $��* �.+�� -   $ grille��$��1��
���   �.+�� -   $��
dock_title��$��10,10,10,950q�.+��� -   $
��MASK��
������� �� CornerRadius$ 80��� -   $��effect��$��2,2,2,2q�.+��� -   $��MASK2�����#999999$ 80��� -   $��effect2��$��1,1,1,1q�.+��� -	   $��MASK3��$ 80��� -
   $
��grid��$��1,1,1,1q��� $
��1460��$	��130��$��0,0,0,20q�$��Center=�$��Bottom=� K� ZIndex$ -1��.+��� -   $��dock_visite��$
��1600��$��0,0,0,0q�$��Center=�$��Center=�
������ 
������ #��[ $��Hidden=����� *	Visites+  �� Color��%�   (��       * SystemColors.HighlightBrushKey+)(��      *$"SystemColors.HighlightTextBrushKey+)(�� (     *SystemColors.ControlBrushKey+)�� $ Transparent���� $ Black���� $ Transparent������ .R�A�  A� Rows$ 1��� -   $��dock_photo_visite��$
��1900��$��10,150,10,150q�$
��Left=��� -   $��pnlRightMenu��$	��780��$��
0,0,-500,0q�$��Right=�$
 1000��$ 
Horizontal=�.+��� -    ��Name$ bdrInfoMASK��$	��490�����	#4C808080
�������$��3q�$ 80��._��  � ColumnDefinitions �� $��20 ��� $��* ��� $��20 �.+�� -   $ pnlInformation��$��1��$ 10�� �� $��30 ��� $
��Auto ��� $��20 ��� $��* ��� $��20 ��� $
��Auto ��� $��30 �.+��� -    ��Name$ lblInfoTitle��$��1��$��Center=�
������ $�� ��$��25(�
��������� -    ��Name$ txtInfoDesc��$��3��
������ $��15(�
�������$�� �� �� TextAlignment$ Justify=�$
��Wrap=�r� -     r�Name$  mediaInfoDesc��$��0��$��4��$
��Auto��$��Bottom=�$ 1000000��$ Uniform=�$ Manual=�$ 0Q����� $ ActualWidth�! �� ElementName$! pnlInformation�� �� *ActualPanorama.Media+�� -   $ txtInfoCopyright��$��5��$
��20,0q�$
��Left=�
������ $��15(�
�������$ Justify=�$
��Wrap=����� *ActualPanorama.Copyright+�� -   " ��Name$" Quit_button��# �� Left$	# 100��
$ �� Top$	$ 681��$��90��$��90��$��
75,960,0,0q�$
��Left=�$	��Top=�
���   �
���   �$y�Visible=�.���� .+��� -   % ��Name$% returnVisite��$��80��$��80��& J� Opacity$	& 1.0Q��� -   $" Info_button��$	# 100��$	$ 681��$��90��$��90��$��1740,960,0,0q�$
��Left=�$	��Top=�
���   �
���   �$y�Visible=�.���� .+��� -   $% 
infoVisite��$��80��$��80��$	& 1.0Q�