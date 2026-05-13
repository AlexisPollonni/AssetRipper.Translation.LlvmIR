using System.Runtime.CompilerServices;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalVariables;

[MangledName("_ZN19__llvm_libc_20_1_2_8internal13signal_bufferE")]
[DemangledName("__llvm_libc_20_1_2_::internal::signal_buffer")]
internal static partial class internal_signal_buffer
{
	[FixedAddressValueType]
	private static InlineArray29_SByte __value;

	public unsafe static InlineArray29_SByte* Pointer => unchecked((InlineArray29_SByte*)Unsafe.AsPointer(ref __value));

	public static InlineArray29_SByte Value
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

	unsafe static internal_signal_buffer()
	{
		PointerIndices.Register(Pointer);
	}
}
