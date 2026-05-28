using System;
using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.InlineArrays;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Printf_core_vasprintf_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_11printf_core18vasprintf_internalEPPcPKcNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::printf_core::vasprintf_internal(char**, char const*, __llvm_libc_20_1_2_::internal::ArgList)")]
	public unsafe static int Invoke([MangledName("ret")][NativeType("char**")] void* Ret, [MangledName("format")][NativeType("char const*")] void* Format, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList")] void* Args)
	{
		InlineArray200_SByte inlineArray200_SByte = default(InlineArray200_SByte);
		Printf_core_WriteBuffer printf_core_WriteBuffer = default(Printf_core_WriteBuffer);
		Printf_core_Writer printf_core_Writer = default(Printf_core_Writer);
		int num = 0;
		Llvm_lifetime_start_p0.Invoke(200L, &inlineArray200_SByte);
		Llvm_memset_p0_i64.Invoke(&inlineArray200_SByte, -86, 200L, isVolatile: false);
		Llvm_lifetime_start_p0.Invoke(56L, &printf_core_WriteBuffer);
		Llvm_memset_p0_i64.Invoke(&printf_core_WriteBuffer, -86, 56L, isVolatile: false);
		WriteBuffer_Constructor.Invoke(&printf_core_WriteBuffer, &inlineArray200_SByte, 200L, Printf_core_resize_overflow_hook.__pointer);
		Llvm_lifetime_start_p0.Invoke(16L, &printf_core_Writer);
		int result;
		unchecked
		{
			*(IntPtr*)(&printf_core_Writer) = unchecked((nint)(-6148914691236517206L));
			((int*)(&printf_core_Writer))[2] = -1431655766;
			sbyte* ptr = (sbyte*)(&printf_core_Writer) + 12;
			*ptr = -86;
			ptr[1] = -86;
			ptr[2] = -86;
			ptr[3] = -86;
			Writer_Constructor.Invoke(&printf_core_Writer, &printf_core_WriteBuffer);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Printf_core_printf_main.Invoke(&printf_core_Writer, Format, (Internal_ArgList*)Args);
			if (num < 0)
			{
				*(IntPtr*)Ret = (nint)0;
				result = -1;
			}
			else
			{
				if (printf_core_WriteBuffer.Buff == &inlineArray200_SByte)
				{
					*(void**)Ret = Malloc.Invoke(checked(num + 1));
					if (Ret == null)
					{
						result = -6;
						goto IL_016d;
					}
					Inline_memcpy.Invoke(*(void**)Ret, printf_core_WriteBuffer.Buff, num);
				}
				else
				{
					*(void**)Ret = printf_core_WriteBuffer.Buff;
				}
				*(sbyte*)((nint)(*(IntPtr*)Ret) + num) = 0;
				result = num;
			}
			goto IL_016d;
		}
		IL_016d:
		Llvm_lifetime_end_p0.Invoke(4L, &num);
		Llvm_lifetime_end_p0.Invoke(16L, &printf_core_Writer);
		Llvm_lifetime_end_p0.Invoke(56L, &printf_core_WriteBuffer);
		Llvm_lifetime_end_p0.Invoke(200L, &inlineArray200_SByte);
		return result;
	}
}
