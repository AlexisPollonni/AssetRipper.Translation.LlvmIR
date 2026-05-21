using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_unsigned_char_vector_16
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadIDv16_hEET_PKNS_3cpp4byteE")]
	[DemangledName("unsigned char vector[16] __llvm_libc_20_1_2_::generic::load<unsigned char vector[16]>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("unsigned char vector[16]")]
	public unsafe static InlineArray16_SByte Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		return load_unsigned_char_vector_16.Invoke(src);
	}
}
