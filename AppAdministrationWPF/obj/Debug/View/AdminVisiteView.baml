   M S B A M L   `   `   `  ����  AppAdministrationWPF/    )AppAdministrationWPF.View.AdminVisiteView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      $
��1665��5      $
��1000��5      $��0q�5	      $
��Left=�5
      $	��Top=�5      .��5      � -   5          �Name$  
LayoutRoot��5      $
��1650��5      $
��1000��5      $��0q�5      $
��Left=�5      $	��Top=�5      
���   � � RowDefinitions 5      �� 5      $��* �6   �� 5      $��80 �6   .+�5      �  � ColumnDefinitions 5      �� 5      $��* �6   �� 5      $��10 �6   �� 5       $��* �6   �� 5!      $��10 �6   �� 5"      $��2* �6   .+�5&      � -   5        $  gridVisiteList��5&   
   $��0��6"    5(      �� 5)      $��60 �6   �� 5*      $��* �6    5-      �� 5.      $	��580 �6   �� 5/      $��* �6   .+�53      �� -   5        $��0��54      $��0��55      $��40��56      $��40��57      $��
10,0,0,100q�58      $
��Left=�59      $��Center=�5:      .��5<      �� -   5         ��Name$ 
flecheHaut��5<      5=      �� 5@      -   5        $��0��5A      $��0��5B      $��40��5C      $��40��5D      $��10,0,0,-100q�5E      $
��Left=�5F      $��Center=�5G      .��5I      �� -   5        $ 	flecheBas��5I      5J      �� 5M      -   5         ��Name$ listboxVisites��5N      $��1��5O      $	��580��5P      $	��350��5Q      $	��350��5R      $
��0,10q�5S      $��Right=�5T      $	��Top=�5U      
������� �� DisplayMemberPath$
 Name��5W      $
��25px(�5X       �� SelectionMode$ Single=�5[      ��5Y      �� *	Visites+5[      �� 5^      -   5        $��dock_miniature��5_      $��1��5`      $��1��5a      $	��300��5b      $	��300��5c      $��20q�5d      $��Center=�5e      $��Center=�5f      $��18(�5g      
�������$��	Miniature��5i      .��5j      r� -	   5        $	��230��5k      $	��230��5l       r� UnloadedBehavior$ Manual=�5o       r� Source 5n      �� *Selected.Thumbnail+5o      5p      5q      � 5t      $��2��6
   .+�5u      �� -
   5        $ listboxPanorama��5v      $	��900��5w      $��10q�5x      $	��Top=�5y      $
 Name��5z      $
��25px(�5{      $ Single=�5      ��5|      �� *Selected.Panoramas+5      5�      � 5�      $��4��6
   .+�5�      �� $��5q�5�      $��Center=�5�      $	��Top=�5�      $��Prévisualisation��5�      $��25(�5�      
�������5�      � 5�      -   5        $��dock_main_photo��5�      $	��800��5�      $	��800��5�      $��0q�5�      $��Center=�5�      $��Center=�5�      $��Disabled=�5�      $��Disabled=�5�      �� 5�      $��Center=�5�      $��Bottom=�5�      	 �� Orientation$	 
Horizontal=�5�      .+�5�      �� -   5        $	��150��5�      $��35��5�      $��10q�5�      #��� ��5�      $��Nouveau panorama��5�      �� 5�      -   5        $	��150��5�      $��35��5�      $��10q�5�      #��� ��5�      $��Modifier panorama��5�      �� 5�      -   5        $	��150��5�      $��35��5�      $��10q�5�      #��� ��5�      $��Supprimer panorama��5�      5�      5�      5�      � 5�      $��2��6	    5�      �� 5�      $	��170 �6   �� 5�      $	��170 �6   �� 5�      $	��170 �6   �� 5�      �� 5�      $	��170 �6   �� 5�      $	��170 �6   
 � 	Resources
 5�       �� 
TargetType �� Property �� Value��%V   '��       �� 5�      " ��6   .�5�      ��  � ��$ Center=�6-   5�      5�      .+�5�      �� -   5         ��Name$ buttonAddVisite��5�      $��0��5�      $	��150��5�      $��35��5�      $��10,22q�5�      #��� ��5�      $��Nouvelle visite��5�      $y�Visible=�5�      �� 5�      -   5        $ buttonModifyVisite��5�      $��1��5�      $	��150��5�      $��35��5�      $��10,22q�5�      #��� ��5�      $��Modifier visite��5�      $y�Visible=�5�      �� 5�      -   5        $ buttonDeleteVisite��5�      $��2��5�      $	��150��5�      $��35��5�      $��10,22q�5�      #��� ��5�      $��Supprimer visite��5�      $y�Visible=�5�      �� 5�      -   5        $ ButtonImporter��5�      $��4��5�      $	��150��5�      $��35��5�      $��10,22q�5�      #��� ��5�      $��Importer��5�      $y�Visible=�5�      �� 5�      -   5        $ ButtonExporter��5�      $��5��5�      $	��150��5�      $��35��5�      $��10,22q�5�      #��� ��5�      $��Exporter��5�      $y�Visible=�5�      5�      5�      5�      