  class House {
      constructor(color) {
          this.color = color
      }
  }

  class HouseBuilder {
      constructor(color) {
          this.house = new House(color)
      }

      setArea(area) {
          this.house.area = area
          return this
      }

      addGarden() {
          this.house.garden = true
          return this
      }

      addSwimPool() {
          this.house.swimPool = true
          return this
      }

      build() {
          return this.house
      }
  }

  const builder = new HouseBuilder('pink')
  const house = builder.setArea(500).addGarden().build();
  console.log(house);