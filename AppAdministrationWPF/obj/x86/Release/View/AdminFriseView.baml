   M S B A M L   `   `   `  ����   AppAdministrationWPF.    (AppAdministrationWPF.View.AdminFriseView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $
��1665��$
��1000��$��0q�$��Center=�$	��Top=�
���   �
���   �$��1q�$��1����Z�   � 	Resources     BaseTemplate  NoNothingButton �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction   Opacity �� 
TargetType  PlaceHoldersList �� Path��%F  &	        &	 #     &	 �    7  �� .R��� ���� *
IconPath+�� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 0q���  �@�Cursor$	 Pen����  � ��$ Center=���  � ��$ Center=�-   ��  � �� �	#01000000��  � z� V� .~��� �� �� T� ��  �@J�Effect   $ 36Q�$	 275Q�$ 0Q���  � �� �� " ��.R��� $��border��#��z��._��� $��Center=�$��Center=��� " ��.���  � �� �� .R��� $��0q���  � �� �� .R��� 8��  ���� $
��None=����� $ IconPath�.��� -   	 �Name$	 	GridFrise��$
��1000��$	��Top=�
���   �
 � RowDefinitions
 �� $	��820 ��� $��1* � � ColumnDefinitions �� $
��1665 �.+��� -    ��Name$ canvasFrise��$
��1490��$	��780��.+��� -    ��Name$ Frise��$��0q�$��Uniform=����� $ ActualWidth� �� ElementName$ canvasFrise������ $ ActualHeight�$ canvasFrise���� -    ��Name$ friseBackground��$
��Left=�$	��Top=�
������ $
��Auto=�#��[ ���� $ ActualWidth�$ canvasFrise������ $ ActualHeight�$ canvasFrise������ *SelectedMap.PlaceHolders+���� .���  �@��Top �� $ Y���  �@��Left �� $ X��� $��1��$��10,10q�
�������$��2q� �� CornerRadius$ 20��._�� -   $	 
grid1Frise��}�.  �� $
��279* ��� $
��201* ��� $
��719* ��� $	��62* ��� $��80 ��� $	��300 �
 �� $	��49* ��� $	��29* ��� $	��78* �.+��� $��0��$��2��$��Center=�$	��Top=�$��16(�
�������$��	276,0,0,0q�$��31��$	��443��.��Modification des Frises :�� $��0��$��2��$��
96,0,73,10q�$��Center=�$��Bottom=� �� Orientation$ 
Horizontal=�$��2��$��35��$	��550��.+��� -    ��Name$ 
btAddFrise��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Ajouter frise����Z� �� -   $ btModifierFrise��$	��150��$��35��$
��50,0q�$��Center=�$��Center=�#��� ��$��Modifier frise����Z� �� -	   $ btDeleteFrise��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Supprimer frise����Z� �� $��2��$��2��$��Center=�$	��Top=�$��16(�
�������$��	276,0,0,0q�$��31��$	��443��.��Modification des Dates :�� $��2��$��2��$��
96,0,73,10q�$��Center=�$��Bottom=�$ 
Horizontal=�$��35��$	��550��.+��� -
   $ btAddPlaceFrise��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Ajouter date����Z� �� -   $ btEditPlaceFrise��$	��150��$��35��$
��50,0q�$��Center=�$��Center=�#��� ��$��Modifier date����Z� �� -   $ btDeletePlaceFrise��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Supprimer date����Z� �� $��3��$��0��$��Center=�$ 
Horizontal=�$��-10,0,190,0q�$��2��$	��300��.+��� -   $ btImporterFrise��$��1��$	��100��$��35��$��25q�$��Center=�$��Center=�#��� ��$��Importer����Z� �� -   $ btExporterFrise��$��0��$	��100��$��35��$��25q�$��Center=�$��Center=�#��� ��$��Exporter����Z� �� -   $��dock_miniature��$��3��$��1��$	��180��$	��150��$��0q�$��Center=�$��Center=�$��18(�
�������$��	Miniature��$��
11,-2,10,8q�.��r� -   $	��160��$	��120�� r� UnloadedBehavior$ Manual=� r� Source �� *SelectedMap.Thumbnail+�� -   $ buttonUpFrise��$��0��$��4��#��� ��$��^��$��24(�$
��15,9q�$��2���� -   $ buttonDownFrise��$��2��$��4��#��� ��$��v��$��24(�$
��15,9q��� -    ��Name$ listboxMapsFrise��$��3��$��5��$
��10,5q� �� DisplayMemberPath$
 Name��$��16(� �� SelectionMode$ Single=����� *Maps+