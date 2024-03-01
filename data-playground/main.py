import csv
pets = []
users = []
with open('mockPets.csv', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        pets.append(row)

with open('mockUsers.csv', newline='') as csvfile:
    spamreader = csv.reader(csvfile, delimiter=' ', quotechar='|')
    for row in spamreader:
        users.append(row)

# print the first pet and users (index 0 is the headers) 
print(str(pets[1]))
print(str(users[1]))