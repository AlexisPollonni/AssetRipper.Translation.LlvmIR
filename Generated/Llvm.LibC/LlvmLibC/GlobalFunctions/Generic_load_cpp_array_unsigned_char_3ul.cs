using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_load_cpp_array_unsigned_char_3ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIhLm3EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>")]
	public unsafe static InlineArray3_Byte Invoke([MangledName("src")][NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* Src)
	{
		Cpp_array_txpwtz cpp_array_txpwtz = default(Cpp_array_txpwtz);
		long num = 0L;
		InlineArray3_Byte result = default(InlineArray3_Byte);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_array_txpwtz);
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				sbyte b = Generic_load_unsigned_char.Invoke((byte*)Src + num * 1L);
				*(sbyte*)Array_unsigned_char_3ul_Index.Invoke(&cpp_array_txpwtz, num) = b;
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
			Llvm_memcpy_p0_p0_i64.Invoke(&result, &cpp_array_txpwtz.Data, 3L, isVolatile: false);
			return result;
		}
	}
}
