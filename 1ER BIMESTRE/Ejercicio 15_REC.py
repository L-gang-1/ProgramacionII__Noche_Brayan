def pedir_datos():
    base=float(input("Ingrese la base:"))
    altura=float(input("Ingrese la altura:"))
    return base,altura
def calcular_area(base,altura):
    area=base*altura
    print(f"Area:{area}")
def calcular_perimetro(base,altura):
    perimetro= 2*(base+altura)
    print(f"perimetro:{perimetro}")
b,a=pedir_datos() 
calcular_area(a,b)
calcular_perimetro(b,a)
    