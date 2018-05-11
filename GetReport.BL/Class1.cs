
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GetReport.BL
{
    public delegate void MyEventDelegate(string _eventParameters);
    public class MyClassWithEvent
    {
        //Открытое событие
        public event MyEventDelegate MyEvent;
        //Обычно метод, отвечающий за возбуждение события делают
        //виртуальным и доступным только для производных классов с тем,
        //чтобы исключить несанкционированное возбуждение событий из вне
        //и позволить производным классам переопределять его поведение
        protected virtual void OnMyEvent(string _MyEventParameters)
        {
            if (MyEvent != null)
                MyEvent(_MyEventParameters);
        }
        //Метод, вызывающий событие
        public void DoSomething()
        {
            OnMyEvent("DoSomething");
        }
        //Еще один метод, вызывающий событие
        public void DoSomethingMore()
        {
            OnMyEvent("DoSomethingMore");
        }
    }
    //Пример обработки событий
    public static class EventSample
    {
        //Обработчик события
        public static void MyEventHandler(string _parameters)
        {
            Console.Write(_parameters, "MyEventHandler");
        }
        //Еще один обработчик события
        public static void MyEventHandler2(string _parameters)
        {
            Console.Write(_parameters, "MyEventHandler2");
        }

        public static void Test()
        {
            MyClassWithEvent myClass = new MyClassWithEvent();
            //Добавляем обработчик события
            myClass.MyEvent += new MyEventDelegate(MyEventHandler);
            //Вызываем метод, вызывающий событие
            myClass.DoSomething();
            //Удаляем обработчик из коллекции обратных вызовов
            myClass.MyEvent -= MyEventHandler;
            //Добавляем другой обработчик по упрощенной схеме
            //(без явного создания делегата)
            myClass.MyEvent += MyEventHandler2;
            //Вызываем второй метод, вызывающий событие
            myClass.DoSomethingMore();
        }
    }

}