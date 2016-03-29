.separator ";"
.import kitbox.utf8.csv "raw"

-- Create table Color
CREATE TABLE "Color" (
    "code" INTEGER PRIMARY KEY NOT NULL,
    "name" VARCHAR(255) NOT NULL
);

-- Fill in the Color table
INSERT INTO "Color" ("name")
SELECT DISTINCT "Couleur"
FROM "raw"
WHERE "Couleur" != "";

-- Create the table Stock
CREATE TABLE "Stock" (
    "code" VARCHAR(255) PRIMARY KEY NOT NULL,
    "name" VARCHAR(255) NOT NULL,
    "height" DOUBLE NOT NULL,
    "depth" DOUBLE NOT NULL,
    "width" DOUBLE NOT NULL,
    "quantity" INTEGER NOT NULL,
    "min_quantity" INTEGER NOT NULL,
    "reserved_quantity" INTEGER DEFAULT(0),
    "price_client" DOUBLE NOT NULL,
    "code_color" INTEGER NOT NULL
);

-- Fill in the table Stock
INSERT INTO "Stock" (
    "code",
    "name",
    "height",
    "depth",
    "width",
    "quantity",
    "min_quantity",
    "price_client",
    "code_color"
) SELECT 
    "raw"."Code",
    TRIM("Réf"),
    "hauteur",
    "profondeur",
    "largeur",
    "Enstock",
    "Stock minimum",
    "Prix-Client",
    "Color"."code"
FROM "raw"
INNER JOIN "Color" 
ON "Color"."name" = "raw"."Couleur";

-- Create the Supplier table
CREATE TABLE "Supplier" (
    "code" INTEGER PRIMARY KEY NOT NULL,
    "name" VARCHAR(255) NOT NULL,
    "address" TEXT NOT NULL
);

-- Fill in the Supplier table
INSERT INTO "Supplier" (
    "name",
    "address"
) VALUES ("1", "");

INSERT INTO "Supplier" (
    "name",
    "address"
) VALUES ("2", "");

-- Create the StockSupplier table
CREATE TABLE "StockSupplier" (
    "code_stock" VARCHAR(255) NOT NULL,
    "code_supplier" INTEGER NOT NULL,
    "price_supplier" DOUBLE NOT NULL,
    "time_delivery" INTEGER NOT NULL,
    PRIMARY KEY ("code_stock", "code_supplier")
);

-- Fill in the table StockSupplier
INSERT INTO "StockSupplier" (
    "code_stock",
    "code_supplier",
    "price_supplier",
    "time_delivery"
) SELECT 
    "Code",
    1,
    "Prix-Fourn 1",
    "Delai-Fourn 1"
FROM "raw";

INSERT INTO "StockSupplier" (
    "code_stock",
    "code_supplier",
    "price_supplier",
    "time_delivery"
) SELECT 
    "raw"."Code",
    2,
    "Prix-Fourn2",
    "Delai-Fourn2"
FROM "raw";

-- Create Status table
CREATE TABLE "Status" (
    "code" INTEGER PRIMARY KEY NOT NULL,
    "name" TEXT NOT NULL
);

-- Create the Order table
CREATE TABLE "Order" (
    "code" INTEGER PRIMARY KEY NOT NULL,
    "name_client" VARCHAR(255) NOT NULL,
    "address_client" VARCHAR(255) NOT NULL,
    "mail_client" VARCHAR(255) NOT NULL,
    "code_status" INTEGER NOT NULL,
    "date" DATETIME NOT NULL,
    "date_removal" DATETIME NOT NULL
);

-- Create the StockOrder table
CREATE TABLE "StockOrder" (
    "code_order" INTEGER NOT NULL,
    "code_stock" VARCHAR(255) NOT NULL,
    "quantity" INTEGER NOT NULL, 
    "quantity_delivered" INTEGER NOT NULL,
    "price" DOUBLE NOT NULL,
    PRIMARY KEY ("code_stock", "code_order")
);

-- Create the OrderSupplier table
CREATE TABLE "OrderSupplier" (
    "code" INTEGER PRIMARY KEY NOT NULL,
    "code_supplier" INTEGER NOT NULL, 
    "date" DATETIME NOT NULL,
    "code_status" INTEGER NOT NULL
);

-- Create the StockOrderSupplier table
CREATE TABLE "StockOrderSupplier" (
    "code_stock" VARCHAR(255) NOT NULL,
    "code_order_supplier" INTEGER NOT NULL,
    "quantity" INTEGER NOT NULL, 
    "price_supplier" DOUBLE NOT NULL,
    PRIMARY KEY ("code_stock", "code_order_supplier")
);

-- Delete the raw table
DROP TABLE raw;
