   M S B A M L   `   `   `  ����L  HGameLauncher_v001, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:GameLauncher_v001GameLauncher_v001  5   	   "    GameLauncher_v001.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:GameLauncher_v001     5   	   -   5          � Title$  	Directory��5   	   $	��300��6   $	��310��6(    � WindowStartupLocation$ CenterScreen=�5	   	   
���   �.��5
      � .+�5   
   �� $��Is your Steam File in: ��6   $
��Left=�62   $��	68,59,0,0q�6M   $	��Top=�6`   	� 5   
   -   5         	�Name$ 	radioBtn0��5      $��C Drive��6)   $
��Left=�6;   $��
88,107,0,0q�6V   $	��Top=�6j   	� 5   
   -   5        $ 	radioBtn1��5      $��D Drive��6)   $
��Left=�6;   $��
88,141,0,0q�6V   $	��Top=�6j   	� 5   
   -   5        $ 	radioBtn2��5      $��Neither��6)   $
��Left=�6;   $��
88,174,0,0q�6V   $	��Top=�6j   �� 5   
   -   5         ��Name$ pasteDirect��5      $
��Left=�6'   $��23��6B   $��
21,204,0,0q�6N   $��Paste Directory��6b   $	��Top=�6y   $	��178��6�   $y�Hidden=�6�   �� 5   
   -   5         ��Name$ 	submitBtn��5      $��Submit��6$    �� 	IsDefault . $
��Left=�6F   $��199,204,0,0q�6a   $	��Top=�6v   $��66��6�   $��23��6�   ���	#FF186A05
���   �$y�Hidden=�6�   �� 5   
   -   5        $ backBtn��5      $
��Back��6"   $
��Left=�61   $��	10,10,0,0q�6L   $	��Top=�6_   $��37��6w   ���	#FFFF0404
���   �
���   �$y�Hidden=�6�   6�   �� 5   
   -   5         ��Name$ isDirectoryLabel��5      $6��0Is your directory, SteamLibrary\steamapps\common��6*   $
��Left=�6e   $��5,89,0,0q�6�   $	��Top=�6�   $y�Hidden=�6�   �� 5   
   -	   5        $ yesBtn��5      $	��Yes��6!   $
��Left=�6/   $��
52,136,0,0q�6J   $	��Top=�6^   $��75��6v   ���	#FF186A05$y�Hidden=�6�   
���   �6�   �� 5   
   -
   5        $ noBtn��5      $��No��6    $
��Left=�6-   $��155,136,0,0q�6H   $	��Top=�6]   $��75��6u   ���	#FFFF0404$y�Hidden=�6�   6�   5      5      