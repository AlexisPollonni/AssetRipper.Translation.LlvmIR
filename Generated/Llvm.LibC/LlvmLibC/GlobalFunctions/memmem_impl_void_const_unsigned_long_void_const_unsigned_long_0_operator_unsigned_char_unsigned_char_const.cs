using AssetRipper.Translation.LlvmIR.Runtime.Attributes;

namespace LlvmLibC.GlobalFunctions;

[MangledName("_ZZN19__llvm_libc_20_1_2_15__memmem_impl__EPKvmS1_mENK3$_0clEhh")]
[DemangledName("__llvm_libc_20_1_2_::__memmem_impl__(void const*, unsigned long, void const*, unsigned long)::$_0::operator()(unsigned char, unsigned char) const")]
internal static partial class memmem_impl_void_const_unsigned_long_void_const_unsigned_long_0_operator_unsigned_char_unsigned_char_const
{
	public unsafe static int Invoke(void* @this, sbyte l, sbyte r)
	{
		return unchecked((byte)l) - unchecked((byte)r);
	}
}
