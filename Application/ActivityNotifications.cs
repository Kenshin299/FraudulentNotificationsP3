using System.Globalization;

namespace Application
{
    public static class ActivityNotifications
    {
        //expenditure = "2 3 4 2 3 6 8 4 5";
        //days = 5;
        public static int getExpenditureNotifications(List<int> expenditure, int days)
        {
            int notifications = 0;
            //TODO: create algorithms

            if (days >= expenditure.Count)
            {
                return notifications;
            }

            // Queue de los ultimos dias
            Queue<int> currentDaysExpenditure = new Queue<int>(expenditure.GetRange(0, days));

            for (int i = days; i < expenditure.Count; i++)
            {
                double median = GetMedianOfList(currentDaysExpenditure);

                if (expenditure[i] >= 2 * median)
                {
                    notifications++;
                }

                currentDaysExpenditure.Dequeue();
                currentDaysExpenditure.Enqueue(expenditure[i]);
            }

            return notifications;
        }

        public static double GetMedianOfList(Queue<int> numbers)
        {
            double median;
            List<int> sortedNumbers = new List<int>(numbers);
            sortedNumbers.Sort();

            if(int.IsEvenInteger(numbers.Count)) //Este metodo es igual (x % 2 == 0)
            {
                var position1 = sortedNumbers[sortedNumbers.Count / 2];
                var position2 = sortedNumbers[(sortedNumbers.Count / 2) - 1];

                median = (position1 + position2) / 2.0;
                return median;
            }
            else
            {
                var position = (sortedNumbers.Count - 1) / 2;
                median = sortedNumbers[position];
                return median;
            }            
        }
    }
}