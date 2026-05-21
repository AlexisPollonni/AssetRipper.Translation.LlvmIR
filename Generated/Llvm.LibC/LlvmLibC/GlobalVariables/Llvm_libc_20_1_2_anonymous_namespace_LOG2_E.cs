using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16LOG2_EE")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::LOG2_E")]
internal static partial class Llvm_libc_20_1_2_anonymous_namespace_LOG2_E
{
	[FixedAddressValueType]
	private static Llvm_libc_20_1_2_NumberPair __value;

	public unsafe static Llvm_libc_20_1_2_NumberPair* Pointer => unchecked((Llvm_libc_20_1_2_NumberPair*)Unsafe.AsPointer(ref __value));

	public static Llvm_libc_20_1_2_NumberPair Value
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

	unsafe static Llvm_libc_20_1_2_anonymous_namespace_LOG2_E()
	{
		Value = new Llvm_libc_20_1_2_NumberPair
		{
			Lo = 2.0355273740931033E-17,
			Hi = 1.4426950408889634
		};
		PointerIndices.Register(Pointer);
	}
}
