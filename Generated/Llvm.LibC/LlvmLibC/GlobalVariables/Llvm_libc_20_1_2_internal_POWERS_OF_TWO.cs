using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internalL13POWERS_OF_TWOE")]
[DemangledName("__llvm_libc_20_1_2_::internal::POWERS_OF_TWO")]
internal static partial class Llvm_libc_20_1_2_internal_POWERS_OF_TWO
{
	[FixedAddressValueType]
	private static InlineArray19_SByte __value;

	public unsafe static InlineArray19_SByte* Pointer => unchecked((InlineArray19_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray19_SByte Value
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

	unsafe static Llvm_libc_20_1_2_internal_POWERS_OF_TWO()
	{
		Value = InlineArrayHelper.Create<InlineArray19_SByte, byte>(new byte[19]
		{
			0, 3, 6, 9, 13, 16, 19, 23, 26, 29,
			33, 36, 39, 43, 46, 49, 53, 56, 59
		});
		PointerIndices.Register(Pointer);
	}
}
