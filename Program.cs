using System;
using System.Collections.Generic;
using System.Timers;

namespace ToDo
{
    internal class Program
    {
        public static List<string> TaskList { get; set; }

        static void Main(string[] args)
        {
            TaskList = new List<string>();
            int menuSelected = 0;
            do
            {
                menuSelected = ShowMainMenu();
                if ((Menu)menuSelected == Menu.Add)
                {
                    ShowMenuAdd();
                }
                else if ((Menu)menuSelected == Menu.Remove)
                {
                    ShowMenuRemove();
                }
                else if ((Menu)menuSelected == Menu.List)
                {
                    ShowMenuTaskList();
                }
            } while ((Menu)menuSelected != Menu.Exit);
        }
        /// <summary>
        /// Show the main menu 
        /// </summary>
        /// <returns>Returns option indicated by user</returns>
        public static int ShowMainMenu()
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Ingrese la opción a realizar: ");
            Console.WriteLine("1. Nueva tarea");
            Console.WriteLine("2. Remover tarea");
            Console.WriteLine("3. Tareas pendientes");
            Console.WriteLine("4. Salir");

            // Read line
            string menuSelected = Console.ReadLine();
            return Convert.ToInt32(menuSelected);
        }

        public static void ShowMenuRemove()
        {
            try
            {
<<<<<<< HEAD
                Console.WriteLine("Ingrese el número de la tarea a remover: ");
                // Show current taks
                PrintTaskList();

                string taskNumberToDelete = Console.ReadLine();
                // Remove one position
                int indexToRemove = Convert.ToInt32(taskNumberToDelete) - 1;
                if (indexToRemove > -1 && TaskList.Count > 0)
                {   
                    string task = TaskList[indexToRemove];
                    TaskList.RemoveAt(indexToRemove);
                    Console.WriteLine("Tarea " + task + " eliminada");                    
=======
                if(TaskList.Count == 0 || TaskList == null) {
                    Console.WriteLine("No hay tareas disponibles para eliminar");
                }
                else
                {
                    Console.WriteLine("Ingrese el número de la tarea a remover: ");
                    // Show current taks
                    for (int i = 0; i < TaskList.Count; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + TaskList[i]);
                    }
                    Console.WriteLine("----------------------------------------");

                    string taskNumberToDelete = Console.ReadLine();
                    // Remove one position
                    int indexToRemove = Convert.ToInt32(taskNumberToDelete) - 1;

                    if (indexToRemove > TaskList.Count - 1 || indexToRemove < 0)
                    {
                        Console.WriteLine("Numero de tarea seleccionado no valido");
                    }
                    else
                    {
                        string taskRemoved = TaskList[indexToRemove];
                        TaskList.RemoveAt(indexToRemove);
                        Console.WriteLine("Tarea " + taskRemoved + " eliminada");
                    }
>>>>>>> try-catch
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
            }
        }

        public static void ShowMenuAdd()
        {
            try
            {
                Console.WriteLine("Ingrese el nombre de la tarea: ");
                string newTask = Console.ReadLine();
<<<<<<< HEAD
                TaskList.Add(newTask);
                Console.WriteLine("Tarea registrada");
=======
                if (newTask == "")
                {
                    Console.WriteLine("Debe ingresar un nombre a la tarea, este no puede ser vacio");
                }
                else
                {
                    TaskList.Add(newTask);
                    Console.WriteLine("Tarea registrada");
                }
>>>>>>> try-catch
            }
            catch (Exception)
            {
                Console.WriteLine("Ha ocurrido un error al eliminar la tarea");
            }
        }

        public static void ShowMenuTaskList()
        {
            if (TaskList == null || TaskList.Count == 0)
            {
                Console.WriteLine("No hay tareas por realizar");
            } 
            else
            {
                Console.WriteLine("----------------------------------------");
                PrintTaskList();
            }
        }

        public static void PrintTaskList()
        {
            var indexTask = 1;
            TaskList.ForEach(task => Console.WriteLine(indexTask++ + ". " + task));
            
            Console.WriteLine("----------------------------------------");
        }
    }


    public enum Menu
    {
        Add = 1,
        Remove = 2,
        List = 3,
        Exit = 4
    }
}