using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_3ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIhLm3EEEE5blockEPNS2_4byteEPKS6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		cpp_array_txpwtz cpp_array_txpwtz2 = default(cpp_array_txpwtz);
		InlineArray3_Byte value = default(InlineArray3_Byte);
		InlineArray3_Byte data = generic_load_cpp_array_unsigned_char_3ul.Invoke(src);
		*unchecked((InlineArray3_Byte*)(&cpp_array_txpwtz2.Data)) = data;
		llvm_memcpy_p0_p0_i64.Invoke(&value, &cpp_array_txpwtz2.Data, 3L, isVolatile: false);
		generic_store_cpp_array_unsigned_char_3ul.Invoke(dst, value);
	}
}
