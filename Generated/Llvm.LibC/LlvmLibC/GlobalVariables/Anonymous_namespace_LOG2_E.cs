using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16LOG2_EE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG2_E")]
internal static partial class Anonymous_namespace_LOG2_E
{
	[FixedAddressValueType]
	private static NumberPair __value;

	public unsafe static NumberPair* Pointer => unchecked((NumberPair*)Unsafe.AsPointer(ref __value));

	public static NumberPair Value
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

	unsafe static Anonymous_namespace_LOG2_E()
	{
		Value = new NumberPair
		{
			Lo = 2.0355273740931033E-17,
			Hi = 1.4426950408889634
		};
		_ = Pointer;
	}
}
