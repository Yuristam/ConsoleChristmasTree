namespace BubbleWorldConsole.Patterns
{
    public class Pattern
    {
        private const string _worldPattern = @"                                                                                                                        
                                                                                                                        
                                     oooooooooooooooo                                                                   
                       o                  oooooooo                                oooooo                                
        oooooooooooooooo ooo oooo  ooo   ooooo                ooooooo  ooooooo oooooooooooooooooooooooooooooooooo       
    ooooooooooooooooooooooo     oo        o                oooo ooooooooooooooooooooooooooooooooooooooooooo  ooo        
             oooooooooooooooo ooooooo                           ooooooooooooooooooooooooooooooooooooooo       oo        
             ooooooooooooooooooo                        oooooooooooooooooooooooooooooooooooooooooooooooooo              
           oooooooooooooooooooo                      oo ooo oo oooooooooooooooooooooooooooooooooooooooooo               
          oooooooooooooooooo                         ooo           oooooooooooooooooooooooooooooooooo   oo              
            ooooooooooooo                            oooooooooo oo   oooooooooooooooooooooooooooooooooo                 
            oooooo      o                          ooooooooooooooooooo ooooo  ooooooooooooooooooooooooo                 
              oooo  oo                            ooooooooooooooooooooo ooooooo       ooooo  ooooo  o                   
                   oooo                          oooooooooooooooooooooooo oo          oo        oooo                    
                      o  ooooooo                   oooooooooooooooooooooooooo          o          o                     
                         ooooooooooo                        ooooooooooooooo                    o      oo                
                        oooooooooooooooo                    ooooooooooooo                        oo  oo         o       
                        oooooooooooooooooo                    oooooooooo                                         o o    
                          ooooooooooooooo                    oooooooooooo                                   ooo  o      
                             ooooooooooo                     ooooooooo    oo                            ooooooooooo     
                             oooooooo                         oooooooo    o                          ooooooooooooooo    
                             oooooooo                          ooooo                                 ooooooooooooooo    
                             oooooo                                                                           ooo       
                              ooo                                                                                       
                              ooo                                                                              oo       
";

        public static void ChoosePattern(ref string userInput)
        {
            Console.Clear();
            Console.Write(
                "Choose pattern:\r\n" +
                "1. World\r\n" +
                "2. Draw your own pattern\r\n" +
                ">");

            userInput = Console.ReadLine().ToLower().Trim();

            switch (userInput)
            {
                case "world": userInput = _worldPattern; ; break;
            }
        }
    }
}
