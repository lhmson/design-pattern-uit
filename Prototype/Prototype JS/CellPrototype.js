class CellOwner {
    constructor(age, size) {
        this.age = age;
        this.size = size;
    }
}

class CellPrototype {
    constructor(name, owner) {
        this.name = name;
        this.owner = owner;
    }
}

class SingleCellOrganism extends CellPrototype {

    clone() {
        var cell = new SingleCellOrganism();
        cell.name = this.name;
        cell.owner = {...this.owner };
        return cell;
    };

    printf() {
        console.log("name: " + this.name + " Single Cell " + this.owner.age + " ages " + this.owner.size + " size");
    };
}


var cellA = new SingleCellOrganism("Lee Sown", { age: 10, size: 100 });
var cellA_1 = cellA.clone();
var cellA_2 = cellA.clone();

cellA_1.name = "Lee Sown 1";
cellA_2.name = "Lee Sown 2";

while (cellA_1.owner.age < 15) {
    cellA_1.owner.age++;
    cellA_1.owner.size *= 2;

    cellA_2.owner.age += 2;
    cellA_2.owner.size *= 4;

    cellA.printf();

    cellA_1.printf();
    cellA_2.printf();

    console.log('\n');
}