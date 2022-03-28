import random

numOfPeople = int(input("Enter number of people: "))

allList = []

for i in range(0, numOfPeople):
    allList.append(i)

usedList = []

print()

while len(allList) > 0:
    randomPicked = allList[random.randrange(0,len(allList))]
    
    while usedList.count(randomPicked) > 1:
        randomPicked = allList[random.randrange(0,len(allList))]
        print("Retrying for " + str(randomPicked))
    
    usedList.append(randomPicked)
    allList.remove(randomPicked)
    print(randomPicked)
    input("Press enter to move to next person")
    
print("All done wooo")