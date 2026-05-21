using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_load_cpp_array_unsigned_char_3ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic4loadINS_3cpp5arrayIhLm3EEEEET_PKNS2_4byteE")]
	[DemangledName("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul> __llvm_libc_20_1_2_::generic::load<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>(__llvm_libc_20_1_2_::cpp::byte const*)")]
	[return: NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>")]
	public unsafe static InlineArray3_Byte Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte const*")] void* src)
	{
		cpp_array_txpwtz cpp_array_txpwtz2 = default(cpp_array_txpwtz);
		long num = 0L;
		InlineArray3_Byte result = default(InlineArray3_Byte);
		unchecked
		{
			sbyte* ptr = (sbyte*)(&cpp_array_txpwtz2);
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				sbyte b = generic_load_unsigned_char.Invoke((byte*)src + num * 1L);
				*(sbyte*)array_unsigned_char_3ul_Index.Invoke(&cpp_array_txpwtz2, num) = b;
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
			llvm_memcpy_p0_p0_i64.Invoke(&result, &cpp_array_txpwtz2.Data, 3L, isVolatile: false);
			return result;
		}
	}
}
