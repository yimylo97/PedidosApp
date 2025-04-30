PedidosApp
Aplicación de escritorio desarrollada en C# Windows Forms que permite gestionar pedidos en una tienda virtual, aplicando los principios SOLID, patrones de diseño y Programación Orientada a Objetos (POO).



- `IMetodoEntrega`: Interfaz para las estrategias de entrega.
- `EntregaDron`, `EntregaMoto`, `EntregaCamion`, `EntregaBicicleta`: Estrategias que implementan la interfaz.
- `EntregaFactory`: Selecciona la estrategia adecuada según las reglas de negocio.
- `Pedido`: Clase que representa un pedido con su información y comportamiento.
- `RegistroPedidos`: Implementación del patrón Singleton para almacenar todos los pedidos.
- `Form1`: Formulario principal para ingresar pedidos.
- `FormHistorial`: Formulario adicional que muestra el historial y permite filtrado por tipo de entrega.

Reglas de Negocio

1. Tecnología + urgente → Dron
2. Accesorio + peso < 2kg + no urgente → Bicicleta
3. Accesorio (otros casos) → Motocicleta
4. Componente o peso > 10kg → Camión
5. Costos por km:
   - Dron: $20
   - Motocicleta: $10
   - Camión: $5
   - Bicicleta: $3

Funcionalidades

- Registro de pedidos con interfaz gráfica.
- Cálculo automático de tipo de entrega y costo.
- Historial de pedidos en un formulario independiente.
- Filtro de historial por tipo de entrega mediante ComboBox.
