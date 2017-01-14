package tv.amis.pamynx.ksp.civpop.beans;

public enum KspPartField implements KspConfigField {
	name,
	module,
	category,
	subcategory,
	author,	
	rescaleFactor(true),
	node_stack_top,
	node_stack_bottom,
	node_stack_left,
	node_stack_right,
	node_stack_front,
	node_stack_back,
	CrewCapacity,
	TechRequired,
	entryCost,
	cost,
	title,
	manufacturer,
	description,
	attachRules,
	mass,
	dragModelType,
	maximum_drag,
	minimum_drag,
	angularDrag,
	crashTolerance,
	breakingForce,
	breakingTorque,
	maxTemp,
	explosionPotential(true),
	;
	
	private boolean option;
	
	private KspPartField(boolean option) {
		this.option = option;
	}

	private KspPartField() {
		this(false);
	}

	public boolean isOption() {
		return option;
	}

}