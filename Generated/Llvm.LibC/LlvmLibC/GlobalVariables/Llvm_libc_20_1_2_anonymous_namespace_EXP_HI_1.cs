using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_12_GLOBAL__N_16EXP_HIE.1")]
[DemangledName("__llvm_libc_20_1_2_::(anonymous namespace)::EXP_HI (.1)")]
internal static partial class Llvm_libc_20_1_2_anonymous_namespace_EXP_HI_1
{
	[FixedAddressValueType]
	private static InlineArray12_Int16 __value;

	public unsafe static InlineArray12_Int16* Pointer => unchecked((InlineArray12_Int16*)Unsafe.AsPointer(ref __value));

	public static InlineArray12_Int16 Value
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

	unsafe static Llvm_libc_20_1_2_anonymous_namespace_EXP_HI_1()
	{
		Value = InlineArrayHelper.Create<InlineArray12_Int16, short>(new short[12]
		{
			1, 2, 6, 17, 47, 128, 348, 946, 2571, 6989,
			18997, 32767
		});
		PointerIndices.Register(Pointer);
	}
}
