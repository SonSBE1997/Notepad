   M S B A M L   `   `   `  ����B  >Nodepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NodepadNodepad  5          Nodepad.App   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      'localclr-namespace:Nodepad     5        �� 	Resources  5       �� 
TargetType   	menu-item �� Triggers P� Property P� Value �� Property �� Value  txb �� Binding �� ElementName	 �� Path
 �� Value��%5  &	        &	 �     '�� �    �� 5   
   " m�6    5      P� 5	       �@J�IsMouseOver . . �5
      ��  � �� �#e3ecf96E   5      5      �� 5   
   " ��6    5      �� 5       6   �� $ mniWordWrap��$	 	IsChecked�
 True6[   .a�5      ��  �@��TextWrapping$
 Wrap=�65   6D   5      �� 5       6   �� $ mniWordWrap��$	 	IsChecked�	
 False6[   .a�5      ��  �@��TextWrapping$ NoWrap=�65   6F   5      5      �� 5   
   " ��6    5      �� 5       6   �� $ 	mnistatus��$	 	IsChecked�
 True6X   .a�5      ��  � y�$ Visible=�63   6E   5      �� 5        6   �� $ 	mnistatus��$	 	IsChecked�	
 False6X   .a�5!      ��  � y�$ 	Collapsed=�63   6G   5"      5$      5&      5'      