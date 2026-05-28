using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Memmove_cpp_array_unsigned_char_3ul_block
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic7MemmoveINS_3cpp5arrayIhLm3EEEE5blockEPNS2_4byteEPKS6_")]
	[DemangledName("__llvm_libc_20_1_2_::generic::Memmove<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>::block(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::byte const*)")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		Cpp_array_txpwtz cpp_array_txpwtz = default(Cpp_array_txpwtz);
		InlineArray3_Byte value = default(InlineArray3_Byte);
		InlineArray3_Byte data = Generic_load_cpp_array_unsigned_char_3ul.Invoke(Src);
		*unchecked((InlineArray3_Byte*)(&cpp_array_txpwtz.Data)) = data;
		Llvm_memcpy_p0_p0_i64.Invoke(&value, &cpp_array_txpwtz.Data, 3L, isVolatile: false);
		Generic_store_cpp_array_unsigned_char_3ul.Invoke(Dst, value);
	}
}
