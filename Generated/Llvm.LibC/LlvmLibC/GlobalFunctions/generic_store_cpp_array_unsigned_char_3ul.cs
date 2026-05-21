using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class generic_store_cpp_array_unsigned_char_3ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeINS_3cpp5arrayIhLm3EEEEEvPNS2_4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* dst, [MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>")] InlineArray3_Byte value)
	{
		cpp_array_txpwtz cpp_array_txpwtz2 = default(cpp_array_txpwtz);
		long num = 0L;
		unchecked
		{
			*(InlineArray3_Byte*)(&cpp_array_txpwtz2.Data) = value;
			llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				generic_store_unsigned_char.Invoke((byte*)dst + num * 1L, *(sbyte*)array_unsigned_char_3ul_Index.Invoke(&cpp_array_txpwtz2, num));
			}
			llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
