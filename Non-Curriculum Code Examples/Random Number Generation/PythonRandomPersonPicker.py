import random

numOfPeople = int(input("Enter number of people: "))

allList = []

for i in range(0, numOfPeople):     #Populating a list with numbers up to the number inputted - exclusive, hence we start at 0
    allList.append(i)

usedList = []                       #Creating an empty list where we will store the used numbers

print()

while len(allList) > 0:
    randomPicked = allList[random.randrange(0,len(allList))]        #Picks a random number from the first list. RandRange is exclusive on both start and stop.
    
    while usedList.count(randomPicked) > 1:                         #This while loop keeps retrying to get a random number that has not been used.
        randomPicked = allList[random.randrange(0,len(allList))]    #Remember RandRange is exclusive
        print("Retrying for " + str(randomPicked))
    
    usedList.append(randomPicked)                                   #Adds the number to the used list
    allList.remove(randomPicked)                                    #Removes the number from the first list
    print(randomPicked)
    input("Press enter to move to next person")
    
print("All done wooo")