using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_15CBRT2E")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::CBRT2")]
internal static partial class Anonymous_namespace_CBRT2
{
	[FixedAddressValueType]
	private static InlineArray3_Double __value;

	public unsafe static InlineArray3_Double* Pointer => unchecked((InlineArray3_Double*)Unsafe.AsPointer(ref __value));

	public static InlineArray3_Double Value
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

	unsafe static Anonymous_namespace_CBRT2()
	{
		Value = InlineArrayHelper.Create<InlineArray3_Double, double>(new double[3] { 1.0, 1.2599210498948732, 1.5874010519681996 });
		_ = Pointer;
	}
}
