   M S B A M L   `   `   `  ����L  HGestion_Stock_PPE, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5clr-namespace:Gestion_Stock_PPEGestion_Stock_PPE  5   	   "    Gestion_Stock_PPE.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   1localclr-namespace:Gestion_Stock_PPE     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
    � -   5          �Name$
 Main��5
        � NavigationUIVisibility$ Hidden=�6   $��
0,-10,0,10q�6>   � 5   
   -   5         �Name$ 	loginGrid��5      $y�Hidden=�6"   $��
0,-10,0,10q�66   .+�5      �� $��	Connexion��6   $
��Left=�6(   $��
83,102,0,0q�6C   $	��Top=�6W   �� 5      $��Login
��6   $
��Left=�6.   $��
53,165,0,0q�6I   $	��Top=�6]    J� RenderTransformOrigin$ 0.5,0.5&�6u   $��32��6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ 0Q�6(   �� 5      T� 5       T� X$ 0Q�6-   5      5      �� 5      $��	Password
��6   $
��Left=�6,   $��
53,241,0,0q�6G   $	��Top=�6[   $ 0.5,0.5&�6s   $��32��6�   z�5      V� 5      .~�5      �� �� 5      $ 0Q�6(   �� 5      T� 5      $ 0Q�6-   5      5       �� 5!      -   5         ��Name$ login��5!   }   $
��Left=�6   $��
53,197,0,0q�61    �� TextWrapping$
 Wrap=�6E   $	��Top=�6Y   $	��120��6q   6}   �� 5"      -   5        $ password��5"      $
��Left=�6(   $��
53,273,0,0q�6C   $
 Wrap=�6W   $	��Top=�6k   $	��120��6�   �� 5#      -   5        $��
Connection��5#      $
��Left=�6*   $��103,327,0,0q�6E   $	��Top=�6Z   6r   5$      � 5%   
   -   5        $ navBarreGrid��5%      $y�Visible=�6%   .+�5&      �� -   5        	 ��Name$	 navBarre��5&      
���   �$��1q�6;   $��Center=�6O   $��64��6l   $	��Top=�6x   $	��800��6�   $��0,10,0,0q�6�   �� 5'      -   5        
 ��Name$
 accueilButton��5'      $��Accueil��6,   $
��Left=�6>   $��	29,26,0,0q�6Y   $	��Top=�6l   $��63��6�   $��32��6�   $ 0.757,0.455&�6�   �� 5(      -	   5        $
 pharmacieButton��5(      $��	Pharmacie��6.   $
��Left=�6B   $��
607,26,0,0q�6]   $	��Top=�6q   $��63��6�   $��32��6�   $ 0.757,0.455&�6�   �� 5)      -
   5        $
 stockButton��5)      $��Stock��6*   $
��Left=�6:   $��
715,26,0,0q�6U   $	��Top=�6i   $��63��6�   $��32��6�   $ 0.757,0.455&�6�   5*      5,      5-      