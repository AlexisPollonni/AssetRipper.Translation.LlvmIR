using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Generic_store_cpp_array_unsigned_char_3ul
{
	[MangledName("_ZN19__llvm_libc_20_1_2_7generic5storeINS_3cpp5arrayIhLm3EEEEEvPNS2_4byteET_")]
	[DemangledName("void __llvm_libc_20_1_2_::generic::store<__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>>(__llvm_libc_20_1_2_::cpp::byte*, __llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>)")]
	[return: NativeType("void")]
	public unsafe static void Invoke([MangledName("dst")][NativeType("__llvm_libc_20_1_2_::cpp::byte*")] void* Dst, [MangledName("value.coerce")][NativeType("__llvm_libc_20_1_2_::cpp::array<unsigned char, 3ul>")] InlineArray3_Byte Value)
	{
		Llvm_libc_20_1_2_cpp_array_txpwtz llvm_libc_20_1_2_cpp_array_txpwtz = default(Llvm_libc_20_1_2_cpp_array_txpwtz);
		long num = 0L;
		unchecked
		{
			*(InlineArray3_Byte*)(&llvm_libc_20_1_2_cpp_array_txpwtz.Data) = Value;
			Llvm_lifetime_start_p0.Invoke(8L, &num);
			for (num = 0L; (ulong)num < 3uL; num++)
			{
				Generic_store_unsigned_char.Invoke((byte*)Dst + num * 1L, *(sbyte*)Array_unsigned_char_3ul_Index.Invoke(&llvm_libc_20_1_2_cpp_array_txpwtz, num));
			}
			Llvm_lifetime_end_p0.Invoke(8L, &num);
		}
	}
}
