using System;
using AssetRipper.Translation.LlvmIR.Runtime;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Internal_accumulate_unsigned_int128
{
	[MangledName("_ZN19__llvm_libc_20_1_2_8internal10accumulateIoEET_iPKhm")]
	[DemangledName("unsigned __int128 __llvm_libc_20_1_2_::internal::accumulate<unsigned __int128>(int, unsigned char const*, unsigned long)")]
	[return: NativeType("unsigned __int128")]
	public unsafe static Struct_fiz2nb Invoke([MangledName("base")][NativeType("int")] int Base, [MangledName("digits")][NativeType("unsigned char const*")] void* Digits, [MangledName("size")][NativeType("unsigned long")] long Size)
	{
		Int128 @int = default(Int128);
		void* ptr = Digits;
		long num = Size;
		Llvm_lifetime_start_p0.Invoke(16L, &@int);
		@int = 0L;
		unchecked
		{
			for (; num != 0L; num += -1L)
			{
				@int = NumericHelper.Multiply(y: Base, x: @int);
				@int = NumericHelper.Add(y: (Int128)(UInt128)(byte)(*(sbyte*)ptr), x: @int);
				ptr = (byte*)ptr + 1;
			}
			Int128 int2 = @int;
			Llvm_lifetime_end_p0.Invoke(16L, &@int);
			return *(Struct_fiz2nb*)(&int2);
		}
	}
}
