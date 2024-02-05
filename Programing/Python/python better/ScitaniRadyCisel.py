promnena = int(input("Napis pocet sectenych cisel: ")) #Input cisla pro secteni

print(" ")

#nastaveni promnenych
count = 0
out = 0

while promnena != 0:                        #Loop funkce secteni
    promnena = promnena - 1                 #Loop
    count = count + 1                       #Pocitani loopu 

    out = out + count                       #samotne scitani

    print(count)

print(" ")
print(r"Sectene cisla: {}".format(out))     #out print
