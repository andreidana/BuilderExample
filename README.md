# BuilderExample

**Definition**: Separates the construction of complex objects from its representation so that the same construction process can create different representations

**Applicability**

- Use when the algorithm for creating complex objects should be independent of the parts that make up the object and how they are represented
- Use when the construction process must allow different representations for the object that is constructed

**Consequences**

- It lets you vary a products internal representation
- It isolates code for construction and representation
- It gives you finer control over the construction process