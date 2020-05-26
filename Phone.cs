namespace Atividade_POO
{
    public class Phone
    {
        public string model; 
        public string color;
        public float size;
        public bool mode;
        public string call;
        public string message;
        public string text;
        public bool metodos;
        public bool calling;
        public string callmessage;

        /// <summary>
        /// Model
        /// </summary>
        /// <returns>Mobile Model</returns>

        public string PhoneModel(){
            return model;
        }
        /// <summary>
        /// Color
        /// </summary>
        /// <returns>Phone color</returns>
        public string PhoneColor(){

            return color;
        }
        /// <summary>
        /// Size
        /// </summary>
        /// <returns>Phone Size</returns>

        public float Phonesize(){

            return size;
        }

        /// <summary>
        /// True: Phone Turn ON or False Phone Turn off and Don't work
        /// </summary>
        /// <returns>Methodos: call and message </returns>

        public string PhoneMode()
        {

            string functions = message;

            if (mode == true)
            {
                functions = message;
                

            }else{
                functions = "...";
            }
            return functions;
        
        }   
        /// <summary>
        /// Choice message if false skip to the call
        /// </summary>
        /// <returns>Message or Call</returns>
           public string Metodos(){
               string texting = text;
               if(metodos == true){

                   texting = text;
               }else{
                   texting = call;
               } return texting;
           }
           /// <summary>
           /// Call
           /// </summary>
           /// <returns>To you type a number</returns>
           public string Call(){

              string messagecall = callmessage;
               if(calling == true){
                   messagecall = callmessage;

               }else{
                   messagecall = "OK";
               }return messagecall;
           }

           



            

        }
    }
