using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Wrapper
{
    public class ResponseWrapper : IResponseWrapper
    {
        public List<string> Messages { get ; set ; }
        public bool isSuccessful { get; set; }

        //Extionstion methood to response for success and failure

        #region success methods
        public static ResponseWrapper Success()
        {
            return new ResponseWrapper
            {
                isSuccessful = true,
               
            };
        } //end of Success method with no message

        public static ResponseWrapper Success(string messages)
        {
            return new ResponseWrapper
            {
                isSuccessful = true,
                Messages = [messages] //this show that the messages is a list of string
            };
        } //end of Success method with one message

        public static ResponseWrapper Success(List<string> messages)
        {
            return new ResponseWrapper
            {
                isSuccessful = true,
                Messages = messages
            };
        } //end of Success method with list of messages


        #endregion 


        #region failures

        public static ResponseWrapper Failure()
        {
            return new ResponseWrapper
            {
                isSuccessful = false
            };
        } //end of Failure method

        public static ResponseWrapper Failure(string messages)
        {
            return new ResponseWrapper
            {
                isSuccessful = false,
                Messages = [messages] //this show that the messages is a list of string
            };
        } //end of Failure method

        //list of messages
        public static ResponseWrapper Failure(List<string> messages)
        {
            return new ResponseWrapper
            {
                isSuccessful = false,
                Messages = messages
            };
        } //end of Failure method

        #endregion 


    }

    //Generic response wrapper
    //this inherit the class and implemnt the interface T
    public class ResponseWrapper<T> : ResponseWrapper, IResponseWrapper<T>
    {
        //this returns the data of type T, which can be any type, and is read-only
        public T Data { get; private set; }
        //Extionstion methood to response for success and failure
        #region success methods

        public new static ResponseWrapper<T> Success()
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,

            };
        } //end of Success method with no message

        public new static ResponseWrapper<T> Success(string messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,
                Messages = [messages] //this show that the messages is a list of string
            };
        } //end of Success method with one message

        //As we override we must use the new keyword to hide the base class method
        public new static ResponseWrapper<T> Success(List<string> messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,
                Messages = messages
            };
        } //end of Success method with list of messages

        //This our first success where we include our data
        public static ResponseWrapper<T> Success(T data)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,
                Data = data
            };
        } //end of Success method with data

        //We are recieving data and a message, so we will return a response with both data and message
        public static ResponseWrapper<T> Success(T data, string messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,
                Data = data,
                Messages = [messages] //this show that the messages is a list of string
            };
        } //end of Success method with data and one message

        //We respond with data and a list of messages, so we will return a response with both data and list of messages
        public static ResponseWrapper<T> Success(T data, List<string> messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = true,
                Data = data,
                Messages = messages
            };
        } //end of Success method with data and list of messages
        #endregion


        #region failure methods
        public new static ResponseWrapper<T> Failure()
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = false
            };
        } //end of Failure method

        public new static ResponseWrapper<T> Failure(string messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = false,
                Messages = [messages] //this show that the messages is a list of string
            };
        } //end of Failure method

        public new static ResponseWrapper<T> Failure(List<string> messages)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = false,
                Messages = messages
            };
        } //end of Failure method

        public static ResponseWrapper<T> Failure(T data)
        {
            return new ResponseWrapper<T>
            {
                isSuccessful = false,
                Data = data
            };
        } //end of Failure method with data

        #endregion for failure methods
    }

}
