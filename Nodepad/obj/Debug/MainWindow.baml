   M S B A M L   `   `   `  ����B  >Nodepad, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:NodepadNodepad  5   	   )clr-namespace:Nodepad.DAONodepad.DAO  5   	       Nodepad.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:Nodepad     5   	   *selfclr-namespace:Nodepad.DAO     5   	   -   5          � Title$  Untitled - Notepad��5	   	   $
��auto��6$   $	��700��62    � Icon$ Resource/notepad.ico��5
   	    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ ApplicationCommands.Print��5      6�     5   
   -   5        $ ApplicationCommands.New��5      6�     5   
   -   5        $ ApplicationCommands.Open��5      6�     5   
   -   5        $ ApplicationCommands.Save��5      6�     5   
   -   5        $  ApplicationCommands.SaveAs��5      6�     5   
   -   5        $" self:CustomCommand.PageSetup��5      6�     5   
   -   5        $ self:CustomCommand.Exit��5      6�     5   
   -	   5        $  ApplicationCommands.Delete��5      6�     5   
   -
   5        $ ApplicationCommands.Find��5      6�     5   
   -   5        $! self:CustomCommand.FindNext��5      6�     5   
   -   5        $! ApplicationCommands.Replace��5      6�     5   
   -   5        $ self:CustomCommand.Goto��5      6�     5   
   -   5        $! self:CustomCommand.TimeDate��5      6�     5   
   -   5        $ self:CustomCommand.Font��5      6�     5    
   -   5        $! self:CustomCommand.ViewHelp��5       6�     5!   
   -   5        $% self:CustomCommand.AboutNotepad��5!      6�   .��5#      ]� .+�5%   
   � $	��Top=�6   $	��Top=�6$   .+�5&      �� $��0,0,0,1q�6   ���#fff._�5'      o� 
�������.@�5)      m� $��_File��6      	menu-item#��[  6.   .@�5*      m� $
��_New��6#    m� Command$ ApplicationCommands.New��61   6U   m� 5+      $��_Open��6#   $ ApplicationCommands.Open��62   6W   m� 5,      $��_Save��6#   $ ApplicationCommands.Save��62   6W   m� 5-      $��Save _As...��6#   $  ApplicationCommands.SaveAs��68   6_   �� 5.      6&   m� 5/      $��Page Set_up...��6#   6=   m� 50      $��	_Print...��6#   $ ApplicationCommands.Print��66   6\   �� 51      6&   m� 52      $��E_xit��6#   $ self:CustomCommand.Exit��62   6V   53      m� 55      $��_Edit��6   #��[  6.   .@�56      m� $��_Undo��6#   $ ApplicationCommands.Undo��62   6W   �� 57      6&   m� 58      $
��Cu_t��6#   $ ApplicationCommands.Cut��61   6U   m� 59      $��_Copy��6#   $ ApplicationCommands.Copy��62   6W   m� 5:      $��_Paste��6#   $ ApplicationCommands.Paste��63   6Y   m� 5;      $��De_lete��6#   $  ApplicationCommands.Delete��64   6[   �� 5<      6&   m� 5=      $��_Find...��6#   $ ApplicationCommands.Find��65   6Z   m� 5>      $��
Find _Next��6#   $! self:CustomCommand.FindNext��67   6_   m� 5?      $��_Replace...��6#   $! ApplicationCommands.Replace��68   6`   m� 5@      $��	_Go To...��6#   $ self:CustomCommand.Goto��66   6Z   �� 5A      6&   m� 5B      $��Select _All��6#   $# ApplicationCommands.SelectAll��68   6b   m� 5C      $��
Time/_Date��6#   $! self:CustomCommand.TimeDate��67   6_   5D      m� 5F      $��F_ormat��6   #��[  60   .@�5G      m� -   5         m�Name$ mniWordWrap��5G   #   $��
_Word Wrap��68    m� IsCheckable . 6a   m� 5H      $��_Font...��6#   $ self:CustomCommand.Font��65   6Y   5I      m� 5K      $��_View��6   #��[  6.   .@�5L      m� -   5        $ 	mnistatus��5L   #   $��_Status Bar��66    . 6a   5M      m� 5O      $��_Help��6   #��[  6.   .@�5P      m� $��
View _Help��6#   $! self:CustomCommand.ViewHelp��67   6_   �� 5Q      6&   m� 5R      $��_About Notepad��6#   $% self:CustomCommand.AboutNotepad��6;   6g   5S      5T      5U      5V      � 5Y   
   -   5         �Name$ gridContent��5Y       � RowDefinitions 5Z      �� 5[      $��1* �6    6.   �� 5\      -   5        	 ��Name$		 row��5\   .   $
��Auto �6    6=   .+�5_      �� -   5        
 ��Name$
 txbData��5_       �� AcceptsReturn .  �� 
AcceptsTab . ��. " �� VerticalScrollBarVisibility$ Visible=�5b      |�.   txb#��[ 5d      $ �� HorizontalScrollBarVisibility$ Visible=�5e      �� 5g      -   5         ��Name$ status��5g      $��20��6(   $��1��64   5h      5i      5j      