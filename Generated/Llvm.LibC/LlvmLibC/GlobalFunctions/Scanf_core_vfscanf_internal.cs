using AssetRipper.Translation.LlvmIR.Runtime.Attributes;
using LlvmLibC.Intrinsics.Implemented;
using LlvmLibC.Structures;

namespace LlvmLibC.GlobalFunctions;

internal static partial class Scanf_core_vfscanf_internal
{
	[MangledName("_ZN19__llvm_libc_20_1_2_10scanf_core16vfscanf_internalEP8_IO_FILEPKcRNS_8internal7ArgListE")]
	[DemangledName("__llvm_libc_20_1_2_::scanf_core::vfscanf_internal(_IO_FILE*, char const*, __llvm_libc_20_1_2_::internal::ArgList&)")]
	public unsafe static int Invoke([MangledName("stream")][NativeType("_IO_FILE*")] void* Stream, [MangledName("format")][NativeType("char const*")] void* Format, [MangledName("args")][NativeType("__llvm_libc_20_1_2_::internal::ArgList&")] Llvm_libc_20_1_2_internal_ArgList* Args)
	{
		Llvm_libc_20_1_2_scanf_core_Reader llvm_libc_20_1_2_scanf_core_Reader = default(Llvm_libc_20_1_2_scanf_core_Reader);
		int num = 0;
		Internal_flockfile.Invoke(Stream);
		Llvm_lifetime_start_p0.Invoke(40L, &llvm_libc_20_1_2_scanf_core_Reader);
		Llvm_memset_p0_i64.Invoke(&llvm_libc_20_1_2_scanf_core_Reader, 0, 40L, isVolatile: false);
		unchecked
		{
			llvm_libc_20_1_2_scanf_core_Reader.Rb = (Llvm_libc_20_1_2_scanf_core_ReadBuffer*)12297829382473034410uL;
			llvm_libc_20_1_2_scanf_core_Reader.Input_stream = (void*)12297829382473034410uL;
			llvm_libc_20_1_2_scanf_core_Reader.Stream_getc = (void*)12297829382473034410uL;
			llvm_libc_20_1_2_scanf_core_Reader.Stream_ungetc = (void*)12297829382473034410uL;
			llvm_libc_20_1_2_scanf_core_Reader.Cur_chars_read = -6148914691236517206L;
			Reader_Constructor.Invoke(&llvm_libc_20_1_2_scanf_core_Reader, Stream, Internal_getc.__pointer, Internal_ungetc.__pointer, null);
			Llvm_lifetime_start_p0.Invoke(4L, &num);
			num = Scanf_core_scanf_main.Invoke(&llvm_libc_20_1_2_scanf_core_Reader, Format, Args);
			if (num == 0 && Internal_ferror_unlocked.Invoke(Stream) != 0)
			{
				num = -1;
			}
			Internal_funlockfile.Invoke(Stream);
			int result = num;
			Llvm_lifetime_end_p0.Invoke(4L, &num);
			Llvm_lifetime_end_p0.Invoke(40L, &llvm_libc_20_1_2_scanf_core_Reader);
			return result;
		}
	}
}
