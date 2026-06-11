#Crea un programa que: Pida numeros de usuario.
#Determine si cada número es par o impar.
#Cuente cuántos números pares y cuántos impares se ingresaron.
#Termine cuando el usuario ingrese 0.
#Muestre al final: Cantidad de números pares, cantidad de números impares.
Numeros_pares=0
Numeros_impares=0
a=1
while a!=0:
    a=int(input("Ingrese el numero:\n"))
    if a %2==0:
        Numeros_pares=Numeros_pares+1
    if a %2==1:
        Numeros_impares=Numeros_impares+1
print("Cantidad de numeros pares:",Numeros_pares)
print("cantidad de numeros impares:",Numeros_impares)

