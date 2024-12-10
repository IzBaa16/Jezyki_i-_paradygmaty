from Vehicle import Car
from abc import ABC, abstractmethod
from EmployeeManager import *
from FrontendManager import *

class Animal(ABC):
    @abstractmethod
    def sound(self):
        pass

class Lion(Animal):
    def sound(self):
        return f"Rawr"

# lion = Lion()
# print(lion.sound())
#
# car1 = Car("Skoda","Octavia","2010")
# print(car1.description())

osoba = EmployeeManager("Marek", 52, 12)
osoba.AddEmployee("Ada", 52, 54)
osoba.AddEmployee("Karolina", 70, 87)
osoba.AddEmployee("Mariola", 65, 60)
osoba.AddEmployee("Janusz", 98, 75)
osoba.AddEmployee("Kazek", 33, 33)

loggedIn = False
while(True):
    if(loggedIn):
        mainMenu(osoba)
    else:
        loggedIn = logIn()


