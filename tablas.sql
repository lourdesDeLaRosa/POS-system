USE db_sistema_ventas_INTEC;
GO


CREATE TABLE rol (
    idrol INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50) NOT NULL,
    descripcion VARCHAR(100)
);


CREATE TABLE persona (
    idpersona INT PRIMARY KEY IDENTITY(1,1),
    tipo_persona VARCHAR(20),
    nombre VARCHAR(100),
    tipo_documento VARCHAR(20),
    num_documento VARCHAR(20),
    direccion VARCHAR(150),
    telefono VARCHAR(20),
    email VARCHAR(100)
);


CREATE TABLE usuario (
    idusuario INT PRIMARY KEY IDENTITY(1,1),
    idrol INT NOT NULL,
    nombre VARCHAR(100),
    tipo_documento VARCHAR(20),
    num_documento VARCHAR(20),
    direccion VARCHAR(150),
    telefono VARCHAR(20),
    email VARCHAR(100),
    clave VARCHAR(100),
    FOREIGN KEY (idrol) REFERENCES rol(idrol)
);


CREATE TABLE categoria (
    idcategoria INT PRIMARY KEY IDENTITY(1,1),
    nombre VARCHAR(50),
    descripcion VARCHAR(100)
);


CREATE TABLE articulo (
    idarticulo INT PRIMARY KEY IDENTITY(1,1),
    idcategoria INT NOT NULL,
    codigo VARCHAR(50),
    nombre VARCHAR(100),
    precio_venta DECIMAL(18,2),
    stock INT,
    descripcion VARCHAR(150),
    imagen VARCHAR(250),
    FOREIGN KEY (idcategoria) REFERENCES categoria(idcategoria)
);


CREATE TABLE ingreso (
    idingreso INT PRIMARY KEY IDENTITY(1,1),
    idproveedor INT NOT NULL,
    idusuario INT NOT NULL,
    tipo_comprobante VARCHAR(20),
    serie_comprobante VARCHAR(20),
    num_comprobante VARCHAR(20),
    fecha DATETIME DEFAULT GETDATE(),
    impuesto DECIMAL(18,2),
    estado VARCHAR(20),
    FOREIGN KEY (idproveedor) REFERENCES persona(idpersona),
    FOREIGN KEY (idusuario) REFERENCES usuario(idusuario)
);


CREATE TABLE detalle_ingreso (
    iddetalle_ingreso INT PRIMARY KEY IDENTITY(1,1),
    idingreso INT NOT NULL,
    idarticulo INT NOT NULL,
    cantidad INT,
    precio_compra DECIMAL(18,2),
    precio_venta DECIMAL(18,2),
    FOREIGN KEY (idingreso) REFERENCES ingreso(idingreso),
    FOREIGN KEY (idarticulo) REFERENCES articulo(idarticulo)
);


CREATE TABLE venta (
    idventa INT PRIMARY KEY IDENTITY(1,1),
    idcliente INT NOT NULL,
    idusuario INT NOT NULL,
    tipo_comprobante VARCHAR(20),
    serie_comprobante VARCHAR(20),
    num_comprobante VARCHAR(20),
    fecha DATETIME DEFAULT GETDATE(),
    impuesto DECIMAL(18,2),
    total DECIMAL(18,2),
    estado VARCHAR(20),
    FOREIGN KEY (idcliente) REFERENCES persona(idpersona),
    FOREIGN KEY (idusuario) REFERENCES usuario(idusuario)
);


CREATE TABLE detalle_venta (
    iddetalle_venta INT PRIMARY KEY IDENTITY(1,1),
    idventa INT NOT NULL,
    idarticulo INT NOT NULL,
    cantidad INT,
    precio_venta DECIMAL(18,2),
    descuento DECIMAL(18,2),
    FOREIGN KEY (idventa) REFERENCES venta(idventa),
    FOREIGN KEY (idarticulo) REFERENCES articulo(idarticulo)
);