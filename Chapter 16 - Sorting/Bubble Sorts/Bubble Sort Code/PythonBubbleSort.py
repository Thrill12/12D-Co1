def bubble_sort(our_list):
    # We go through the list as many times as there are elements
    for i in range(len(our_list)):
        # We want the last pair of adjacent elements to be (n-2, n-1)
        for j in range(len(our_list) - 1):
            if our_list[j] > our_list[j+1]:
                # Swap - python doesn't necessarily require a temporary variable, however that would work just as well
                # This is a python only feature I'm afraid, as their internal lists are a bit strange and work in
                # a unique way
                our_list[j], our_list[j+1] = our_list[j+1], our_list[j]

ourList = [5, 4, 2, 8, 9, 15, 2, 6, 5, 12]
bubble_sort(ourList)
print(ourList)