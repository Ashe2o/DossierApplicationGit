   M S B A M L   `   `   `  ����   AppAdministrationWPF/    )AppAdministrationWPF.View.AdminRegionView   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     $
��1665��$
��1000��$��0q�$��Center=�$	��Top=�
���   �
���   �$��1q�$��1����Z�   � 	Resources     BaseTemplate  NoNothingButton �� 
TargetType �� Property �� Value3  -System.Windows.Media.Effects.DropShadowEffect   
BlurRadius   	Direction   Opacity �� 
TargetType  PlaceHoldersList �� Path��%F  &	        &	 #     &	 �    7  �� .R��� ���� *
IconPath+�� " ��.���  �@�OverridesDefaultStyle . ��  � ��$ 0q���  �@�Cursor$	 Pen����  � ��$ Center=���  � ��$ Center=�-   ��  � �� �	#01000000��  � z� V� .~��� �� �� T� ��  �@J�Effect   $ 36Q�$	 275Q�$ 0Q���  � �� �� " ��.R��� $��border��#��z��._��� $��Center=�$��Center=��� " ��.���  � �� �� .R��� $��0q���  � �� �� .R��� 8��  ���� $
��None=����� $ IconPath�.��� -   	 �Name$	 GridMap��$
��1000��$	��Top=�
���   �
 � RowDefinitions
 �� $	��820 ��� $��1* � � ColumnDefinitions �� $
��1665 �.+��� -    ��Name$ canvasCarte��$
��1490��$	��780��.+��� -    ��Name$ Carte��$��0q�$��Uniform=����� $ ActualWidth� �� ElementName$ canvasCarte������ $ ActualHeight�$ canvasCarte���� -    ��Name$ mapBackground��$
��Left=�$	��Top=�
������ $
��Auto=�#��[ ���� $ ActualWidth�$ canvasCarte������ $ ActualHeight�$ canvasCarte������ *SelectedMap.PlaceHolders+���� .���  �@��Top �� $ Y���  �@��Left �� $ X��� $��1��$��10,10q�
�������$��2q� �� CornerRadius$ 20��._�� -   $	 grid1��}�.  �� $
��279* ��� $
��201* ��� $
��719* ��� $	��62* ��� $��80 ��� $	��300 �
 �� $	��49* ��� $	��29* ��� $	��78* �.+��� $��0��$��2��$��Center=�$	��Top=�$��16(�
�������$��	276,0,0,0q�$��31��$	��443��.��Modification des Cartes :�� $��0��$��2��$��
96,0,73,10q�$��Center=�$��Bottom=� �� Orientation$ 
Horizontal=�$��2��$��2��.+��� -    ��Name$ btAddMap��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Ajouter carte����Z� �� -   $ btModifierCarte��$	��150��$��35��$
��50,0q�$��Center=�$��Center=�#��� ��$��Modifier carte����Z� �� -	   $ btDeleteMap��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Supprimer carte����Z� �� $��2��$��2��$��Center=�$	��Top=�$��16(�
�������$��	276,0,0,0q�$��31��$	��443��.��Modification des Lieux :�� $��2��$��2��$��
96,0,73,10q�$��Center=�$��Bottom=�$ 
Horizontal=�$��2��.+��� -
   $ 
btAddPlace��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Ajouter lieu����Z� �� -   $ btEditPlace��$	��150��$��35��$
��50,0q�$��Center=�$��Center=�#��� ��$��Modifier lieu����Z� �� -   $ btDeletePlace��$	��150��$��35��$��Center=�$��Center=�#��� ��$��Supprimer lieu����Z� �� $��3��$��0��$��Center=�$ 
Horizontal=�$��-10,0,190,0q�$��2��.+��� -   $ 
btImporter��$��1��$	��100��$��35��$��25q�$��Center=�$��Center=�#��� ��$��Importer����Z� �� -   $ 
btExporter��$��0��$	��100��$��35��$��25q�$��Center=�$��Center=�#��� ��$��Exporter����Z� �� -   $��dock_miniature��$��3��$��1��$	��180��$	��150��$��0q�$��Center=�$��Center=�$��18(�
�������$��	Miniature��$��0,0,0,10q�.��r� -   $	��160��$	��120�� r� UnloadedBehavior$ Manual=� r� Source �� *SelectedMap.Thumbnail+�� -   $ buttonUp��$��0��$��4��$��50��$��60��#��� ��$��^��$��24(�$
��15,9q�$��2���� -   $ 
buttonDown��$��2��$��4��$��50��$��60��#��� ��$��v��$��24(�$
��15,9q��� -    ��Name$ listboxMaps��$��3��$��5��$
��10,5q� �� DisplayMemberPath$
 Name��$��16(� �� SelectionMode$ Single=����� *Maps+