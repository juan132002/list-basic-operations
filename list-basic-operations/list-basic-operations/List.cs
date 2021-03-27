using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace list_basic_operations
{
    public class List
    {
        CourtRentalNodo Head;

        public void Add(CourtRental courtRentalToAdd)
        {
            CourtRentalNodo newcourtRentalNodo = new CourtRentalNodo();
            newcourtRentalNodo.CourtRental = courtRentalToAdd;

            if (Head == null)
            {
                Head = newcourtRentalNodo;
            }
            else
            {
                CourtRentalNodo last = Head;
                while (last.Next != null)
                {
                    last = last.Next;
                }
                last.Next = newcourtRentalNodo;

            }


        }

        public void Insert(CourtRental courtRentalToInsert, int posicion)
        {
            CourtRentalNodo newcourtRentalNodo = new CourtRentalNodo();
            newcourtRentalNodo.CourtRental = courtRentalToInsert;
            newcourtRentalNodo.Next = null;
            if (Head == null)
            {
                Head = newcourtRentalNodo;
            }
            else
            {
                CourtRentalNodo last;
                last = Head;
                if (posicion == 1)
                {
                    Head = newcourtRentalNodo;
                    newcourtRentalNodo.Next = last;
                }
                else
                {
                    for (int i = 1; i < posicion - 1; i++)
                    {
                        last = last.Next;
                        if (last.Next == null) break;
                    }

                    CourtRentalNodo lastnext;
                    lastnext = last.Next;
                    last.Next = newcourtRentalNodo;
                    newcourtRentalNodo = lastnext;
                }
            }
        }

        public void Print()
        {
            CourtRentalNodo tmp = Head;
            while (tmp != null)
            {
                Console.WriteLine($"the court costs: {tmp.CourtRental.Cost} -> the court time is: {tmp.CourtRental.Time} -> the type of court is: {tmp.CourtRental.Type}");
                tmp = tmp.Next;
            }
        }

    }

}

