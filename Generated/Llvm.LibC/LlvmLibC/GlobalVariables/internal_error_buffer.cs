using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal12error_bufferE")]
[DemangledName("__llvm_libc_20_1_2_::internal::error_buffer")]
internal static partial class internal_error_buffer
{
	[FixedAddressValueType]
	private static InlineArray26_SByte __value;

	public unsafe static InlineArray26_SByte* Pointer => unchecked((InlineArray26_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray26_SByte Value
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

	unsafe static internal_error_buffer()
	{
		PointerIndices.Register(Pointer);
	}
}
