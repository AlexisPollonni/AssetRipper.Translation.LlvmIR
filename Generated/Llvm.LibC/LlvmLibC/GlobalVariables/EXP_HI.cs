using System;
using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_L6EXP_HIE")]
[DemangledName("__llvm_libc_20_1_2_::EXP_HI")]
internal static partial class EXP_HI
{
	[FixedAddressValueType]
	private static cpp_array_55dk65 __value;

	public unsafe static cpp_array_55dk65* Pointer => unchecked((cpp_array_55dk65*)Unsafe.AsPointer(ref __value));

	public static cpp_array_55dk65 Value
	{
		get
		{
			return __value;
		}
		set
		{
			__value = value;
		}
	}

	unsafe static EXP_HI()
	{
		Value = new cpp_array_55dk65
		{
			Data = InlineArrayHelper.Create<InlineArray31_Single, float>(new float[31]
			{
				1.5229979E-08f,
				4.1399378E-08f,
				1.12535176E-07f,
				3.0590232E-07f,
				8.315287E-07f,
				2.2603294E-06f,
				6.1442124E-06f,
				1.67017E-05f,
				4.539993E-05f,
				0.0001234098f,
				0.00033546262f,
				0.000911882f,
				0.0024787523f,
				0.006737947f,
				0.01831564f,
				0.049787067f,
				0.13533528f,
				1f / (float)Math.E,
				1f,
				(float)Math.E,
				7.389056f,
				20.085537f,
				54.59815f,
				148.41316f,
				403.4288f,
				1096.6332f,
				2980.958f,
				8103.084f,
				22026.465f,
				59874.14f,
				162754.8f
			})
		};
		PointerIndices.Register(Pointer);
	}
}
