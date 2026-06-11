#sacr el imc de varis o una persona
def Calcular_IMC(peso,altura):
    if altura<= 0:
        return 0
    imc=peso/(altura**2)
    return imc
def clasificar_imc(imc):
    if imc==0:
        return "DATOS INVALIDO"
    elif imc < 18.5:
        return "BAJO PESO"
    elif imc >= 18.5 and imc <24:
        return "peso normal"
    elif imc >24 and imc<=30:
        return "sobre peso"
    elif imc >30:
        return "OBESIDAD"
def pedir_Datos():
    peso=float(input("Ingrese su peso:"))
    altura=float(input("Ingrese su altura:"))
    return peso,altura
peso,altura= pedir_Datos()
imc=Calcular_IMC(peso,altura)
categoria=clasificar_imc(imc)


print("Los resultados son:")
print("Ingrese el peso y altura",peso,altura)
print("El resultado sobre el IMC es:",imc)
print("Usted esta en la categoria :",categoria)