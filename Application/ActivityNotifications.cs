﻿namespace Application
{
    public static class ActivityNotifications
    {
        //expenditure = "2 3 4 2 3 6 8 4 5";
        public static int getExpenditureNotifications(List<int> expenditure, int days)
        {
            int notifications = 0;
            //TODO: create algorithms

           int median = GetMedianOfList(expenditure);

            return notifications;
        }

        public static int GetMedianOfList(List<int> numbers)
        {
            int median = 0;
            numbers.Sort();

            if(int.IsEvenInteger(numbers.Count))
            {
                var position1 = numbers[numbers.Count / 2];
                var position2 = numbers[(numbers.Count / 2) - 1];

                median = (position1 + position2) / 2;
                return median;
            }
            else
            {
                var position = (numbers.Count - 1) / 2;
                median = numbers[position];
                return median;
            }            
        }
    }
}