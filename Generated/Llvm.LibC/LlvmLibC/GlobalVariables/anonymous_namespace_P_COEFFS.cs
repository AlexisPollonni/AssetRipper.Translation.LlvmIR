using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_18P_COEFFSE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::P_COEFFS")]
internal static partial class anonymous_namespace_P_COEFFS
{
	[FixedAddressValueType]
	private static InlineArray6_Double __value;

	public unsafe static InlineArray6_Double* Pointer => unchecked((InlineArray6_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray6_Double Value
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

	unsafe static anonymous_namespace_P_COEFFS()
	{
		Value = InlineArrayHelper.Create<InlineArray6_Double, double>(new double[6] { -0.5, 0.3333333333332774, -0.24999999993354488, 0.20000000691205155, -0.1666726232084424, 0.14267603557865907 });
		PointerIndices.Register(Pointer);
	}
}
