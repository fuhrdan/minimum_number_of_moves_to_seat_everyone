//***************************************************************
//** This method sorts the two lists, then subtracts the ********
//** absolute value to find the solution.                ********
//** By Dan                                              ********
//***************************************************************
//***************************************************************

int minMovesToSeat(int* seats, int seatsSize, int* students, int studentsSize) {
    int moves = 0;
    int swap;
    
    for(int x = 0; x < seatsSize; x++)
    {
        for(int y = 0; y < seatsSize; y++)
        {
            if(seats[x] < seats[y])
            {
                swap = seats[x];
                seats[x] = seats[y];
                seats[y] = swap;
            }
            if(students[x] < students[y])
            {
                swap = students[x];
                students[x] = students[y];
                students[y] = swap;
            }
        }
    }
    for(int i = 0; i < seatsSize; i++)
    {
        moves += abs(seats[i] - students[i]);
    }

    return moves;
}