   M S B A M L   `   `   `  ����   AppAdministrationWPF0    *AppAdministrationWPF.View.VisiteEditDialog   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml       � Title$$  Customisation visite virtuelle��$	��400��$	��550�� � 
ResizeMode$ CanResizeWithGrip=� � ShowInTaskbar .   � Topmost . .��� .+��� $	��190��$��	8,8,8,152q�$	��Top=�
���   �$��1q�._�r� -    r�Name$ Apercu�� r� Stretch$ Uniform=� r� Volume$ 0Q� r� Source �� *	Thumbnail+� $	��300��$��8,0,8,8q�$��Bottom=� � RowDefinitions �� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto ��� $
��Auto �	 � ColumnDefinitions	 �� $��1* ��� $��2* ��� $��1* �.+��� $��0��$��0��$��Right=�$��Center=�$��Nom :���� -   $��txtName��$��0��$��1��$��Stretch=�$��Center=����� *Name+�� $��1��$��0��$��Right=�$��Center=�.��HTML Visite :�� -   $��txtCover��$��1��$��1��$��Stretch=�$��Center=�{�.  ���� *Cover+�� -   $��btOpen��$��1��$��2��$��75��$��Stretch=�$��Center=�$��Parcourir...���� $��2��$��0��$��Right=�$��Center=�$��Miniature :���� -   
 ��Name$
 txtThumbnail��$��2��$��1��$��Stretch=�$��Center=�{�.  ���� *	Thumbnail+�� -    ��Name$ btMiniature��$��2��$��2��$��75��$��Stretch=�$��Center=�$��Parcourir...���� $��3��$��0��$��Right=�$��Center=�$��
Titre FR :���� -   $��
txtTitleFR��$��3��$��1��$��Stretch=�$��Center=� �� MaxLines$	 100������ *	TitleFR+�� $��4��$��0��$��Right=�$��Center=�$��Titre CAT :���� -   $��txtTitleCAT��$��4��$��1��$��Stretch=�$��Center=�$	 100������ *
TitleCAT+�� $��5��$��0��$��Right=�$��Center=�$��
Titre EN :���� -	   $��
txtTitleEN��$��5��$��1��$��Stretch=�$��Center=�$	 100������ *	TitleEN+�� $��6��$��0��$��Right=�$��Center=�$��
Titre ES :���� -
   $��
txtTitleES��$��6��$��1��$��Stretch=�$��Center=�$	 100������ *	TitleES+�� $��7��$��0��$��Right=�$��Center=�$��
Titre DE :���� -   $��
txtTitleDE��$��7��$��1��$��Stretch=�$��Center=�$	 100������ *	TitleDE+�� $��8��$��0��$��Right=�$	��Top=�$��Source Media :���� -   $��	txtSource��$��8��$��1��$��Stretch=�$��Center=�$ 2������ *Source+�� -   $��stackPanel1��$��9��$��0��$��3��$
��0,10q�$��Center=�$��Bottom=� �� Orientation$ 
Horizontal=�.+��� -   $
��btOK��$��60��$��2q�$��OK��$
��Bold"��� -   $��btCancel��$��60��$��2q�$��Annuler��